using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class LessonService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public LessonService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Lesson>> GetAllLessons()
        {
            var lessons = await DiaryDbContext.Lesson.ToListAsync();

            return lessons;
        }

        public async Task<List<List<Lesson>>> GetClassLessons(int ClassID)
        {
            if (ClassID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var subjects = await DiaryDbContext.PersonClass
                .Include(x => x.Class)
                .ThenInclude(x => x.Subject)!
                .ThenInclude(x => x.Lesson)
                .Select(x => x.Class!.Subject!.Where(x => x.FK_Class == ClassID))
                .SelectMany(x => x)
                .GroupBy(x => x.FK_LessonID)
                .Select(x => x.First())
                .ToListAsync();

            if (subjects.Count <= 0)
            {
                throw new ArgumentNullException("Lessons class dosen't exists");
            }

            var lessons = subjects
                .Select(x => x.Lesson)
                .OrderBy(x => x.Day)
                .ToList();


            var lessonList = new List<List<Lesson>>();

            for (int i = 1; i < 6; i++)
            {
                lessonList.Add(lessons.Where(x => x.Day == i).ToList()!);
            } 

            return lessonList;
        }

        public async Task CreateLesson(LessonDto lesson)
        {
            if (lesson is null)
            {
                throw new ArgumentNullException("Invalid data");
            }
            
            await DiaryDbContext.AddAsync(new Lesson()
            {
                Name = lesson.Name,
                Hour = lesson.Hour,
                Day = lesson.Day,
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeLesson(int id, LessonDto lesson)
        {
            if (id.Equals(0) || lesson is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var lessonToChange = await DiaryDbContext.Lesson.FirstOrDefaultAsync(x => x.LessonID == id);

            if (lessonToChange is null)
            {
                throw new NullReferenceException("Given lesson dosen't exist");
            }

            lessonToChange.Name = lesson.Name;
            lessonToChange.Hour = lesson.Hour;
            lessonToChange.Day = lesson.Day;

            DiaryDbContext.Update(lessonToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteLesson(int id)
        {
            if (id.Equals(0))
            {
                throw new NullReferenceException("Invalid data");
            }

            var lessonToDelete = await DiaryDbContext.Lesson.FirstOrDefaultAsync(x => x.LessonID == id);

            if (lessonToDelete is null)
            {
                throw new ArgumentNullException("Given lesson dosen't exist");
            }

            DiaryDbContext.Remove(lessonToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
