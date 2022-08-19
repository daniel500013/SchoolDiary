using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class MarkService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public MarkService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Mark>> GetAllMarks()
        {
            var marks = await DiaryDbContext.Mark.ToListAsync();

            return marks;
        }

        public async Task<List<Mark>> GetClassMarks(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var checkClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassNumber == id);

            if (checkClassExist is null)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            var users = await DiaryDbContext.PersonClass
                .Where(x => x.FK_ClassID == id)
                .Select(x => x.FK_UserUUID)
                .ToListAsync();

            if (users.Count <= 0)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            List<Mark> marks = new List<Mark>();

            for (int i = 0; i < users.Count; i++)
            {
                var tmp_mark = await DiaryDbContext.Mark
                    .Where(x => x.FK_UserUUID == users[i])
                    .ToListAsync();

                if (tmp_mark is null)
                {
                    throw new ArgumentNullException("Person dosen't exist");
                }

                for (int j = 0; j < tmp_mark.Count; j++)
                {
                    marks.Add(tmp_mark[j]);
                }
            }

            marks = marks.GroupBy(x => x.Date).Select(x => x.First()).OrderByDescending(x => x.Date).ToList();

            return marks;
        }

        public async Task<List<MarkManagerDto>> GetUserMarks(Guid uuid)
        {
            if (uuid.ToString().Length <= 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var marks = await DiaryDbContext.LessonMark
                .Include(x => x.Mark)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (marks.Count <= 0)
            {
                throw new ArgumentNullException("No marks");
            }

            var markLesson = await DiaryDbContext.LessonMark
                .Include(x => x.Lesson)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonMarks!.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            return marks.Select((t, i) => new MarkManagerDto()
                {
                    Present = t.Present,
                    Data = t.Date,
                    LessonName = markLesson[i]
                }).ToList();
        }

        public async Task AddMark(MarkDto markDto)
        {
            if (markDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == markDto.Lesson)
                .Where(x => x.Day == markDto.Day)
                .Where(x => x.Hour == markDto.Hour)
                .Where(x => x.Subjects!.FirstOrDefault(x => x.FK_Class == markDto.Class)!.FK_Class == markDto.Class)
                .FirstOrDefaultAsync();

            if (lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var mark = new Mark()
            {
                Date = DateTime.Now.Date,
                Present = markDto.Present,
                FK_UserUUID = markDto.UserUUID
            };

            await DiaryDbContext.AddAsync(mark);
            await DiaryDbContext.SaveChangesAsync();

            var lessonMark = new LessonMark()
            {
                FK_MarkID = mark.MarkID,
                FK_LessonID = lesson.LessonID
            };

            await DiaryDbContext.AddAsync(lessonMark);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task<List<MarkChangeViewModel>> GetChangeMarksUsers(MarkChangeDto markDto)
        {
            if (markDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == markDto.Lesson)
                .Where(x => x.Day == markDto.Day)
                .Where(x => x.Hour == markDto.Hour)
                .Where(x => x.Subjects!.FirstOrDefault(x => x.FK_Class == markDto.Class)!.FK_Class == markDto.Class)
                .FirstOrDefaultAsync();

            if (lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var users = await DiaryDbContext.LessonMark
                .Include(x => x.Mark)
                .ThenInclude(x => x.Person)
                .Where(x => x.FK_LessonID == lesson.LessonID)
                .Select(x => x.Mark)
                .Where(x => x.Date == markDto.Date)
                .ToListAsync();

            if (users.Count <= 0)
            {
                throw new ArgumentNullException("Empty mark list");
            }

            return users.Select(t => new MarkChangeViewModel()
                {
                    Present = t.Present,
                    MarkID = t.MarkID,
                    FirstName = t.Person!.FirstName,
                    LastName = t.Person.LastName
                }).ToList();
        }

        public async Task ChangeMark(int id, MarkDto mark)
        {
            if (mark is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var checkMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (checkMarkExist is null)
            {
                throw new ArgumentNullException("Given mark id dosen't exist");
            }

            checkMarkExist.Present = mark.Present;

            DiaryDbContext.Update(checkMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteMark(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var checkMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (checkMarkExist is null)
            {
                throw new ArgumentNullException("Mark dosen't exist");
            }

            DiaryDbContext.Remove(checkMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
