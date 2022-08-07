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

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassNumber == id);

            if (CheckClassExist is null)
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

            return marks;
        }

        public async Task<List<MarkManagerDto>> GetUserMarks(Guid uuid)
        {
            if (uuid.ToString().Length <= 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Marks = await DiaryDbContext.LessonMark
                .Include(x => x.Mark)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (Marks.Count <= 0)
            {
                throw new ArgumentNullException("No marks");
            }

            var MarkLesson = await DiaryDbContext.LessonMark
                .Include(x => x.Lesson)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonMarks.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            List<MarkManagerDto> MarksDto = new List<MarkManagerDto>();

            for (int i = 0; i < Marks.Count; i++)
            {
                MarksDto.Add(new MarkManagerDto() { Present = Marks[i].Present, Data = Marks[i].Date.ToString("dd/mm/yyyy"), LessonName = MarkLesson[i] });
            }

            return MarksDto;
        }

        public async Task AddMark(MarkDto markDto)
        {
            if (markDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == markDto.Lesson)
                .Where(x => x.Day == markDto.Day)
                .Where(x => x.Hour == markDto.Hour)
                .Where(x => x.Subjects.FirstOrDefault(x => x.FK_Class == markDto.Class).FK_Class == markDto.Class)
                .FirstOrDefaultAsync();

            if (Lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var Mark = new Mark()
            {
                Date = DateTime.Now.Date,
                Present = markDto.Present,
                FK_UserUUID = markDto.UserUUID
            };

            await DiaryDbContext.AddAsync(Mark);
            await DiaryDbContext.SaveChangesAsync();

            var LessonMark = new LessonMark()
            {
                FK_MarkID = Mark.MarkID,
                FK_LessonID = Lesson.LessonID
            };

            await DiaryDbContext.AddAsync(LessonMark);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeMark(int id, MarkDto mark)
        {
            if (mark is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (CheckMarkExist is null)
            {
                throw new ArgumentNullException("Given mark id dosen't exist");
            }

            CheckMarkExist.Present = mark.Present;

            DiaryDbContext.Update(CheckMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteMark(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (CheckMarkExist is null)
            {
                throw new ArgumentNullException("Mark dosen't exist");
            }

            DiaryDbContext.Remove(CheckMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
