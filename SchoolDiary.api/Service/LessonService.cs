﻿namespace SchoolDiary.api.Service
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

        public async Task CreateLesson(LessonViewModel lesson)
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

        public async Task ChangeLesson(int id, LessonViewModel lesson)
        {
            if (id.Equals(0) || lesson is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var LessonToChange = await DiaryDbContext.Lesson.FirstOrDefaultAsync(x => x.LessonID == id);

            if (LessonToChange is null)
            {
                throw new NullReferenceException("Given lesson dosen't exist");
            }

            LessonToChange.Name = lesson.Name;
            LessonToChange.Hour = lesson.Hour;
            LessonToChange.Day = lesson.Day;

            DiaryDbContext.Update(LessonToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteLesson(int id)
        {
            if (id.Equals(0))
            {
                throw new NullReferenceException("Invalid data");
            }

            var LessonToDelete = await DiaryDbContext.Lesson.FirstOrDefaultAsync(x => x.LessonID == id);

            if (LessonToDelete is null)
            {
                throw new ArgumentNullException("Given lesson dosen't exist");
            }

            DiaryDbContext.Remove(LessonToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}