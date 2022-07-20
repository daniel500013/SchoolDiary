﻿namespace SchoolDiary.api.Service
{
    public class GradeManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public GradeManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<LessonGrade>> GetAllUsersGrades()
        {
            var lessonGrades = await DiaryDbContext.LessonGrade.ToListAsync();

            return lessonGrades;
        }

        public async Task<List<Grade?>> GetUserGrades(Guid uuid)
        {
            if (uuid.ToString().Length <= 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == uuid);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            var Grades = await DiaryDbContext.LessonGrade
                .Include(x => x.Grade)
                .Select(x => x.Grade)
                .ToListAsync();

            if (Grades.Count <= 0)
            {
                throw new ArgumentNullException("No grades");
            }

            return Grades;
        }

        public async Task AssignGradeToLesson(GradeManagerViewModel grade)
        {
            if (grade is null)
            {
                throw new ArgumentNullException("invalid data");
            }

            await DiaryDbContext.AddAsync(new LessonGrade()
            {
                FK_GradeID = grade.FK_GradeID,
                FK_LessonID = grade.FK_LessonID,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeAssignGradeToLesson(int id, GradeManagerViewModel grade)
        {
            if (id.Equals(0) || grade is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var LessonGradeToChange = await DiaryDbContext.LessonGrade.FirstOrDefaultAsync(x => x.GradeLessonID == id);

            if (LessonGradeToChange is null)
            {
                throw new ArgumentNullException("Grade assign dosen't exist");
            }

            LessonGradeToChange.FK_LessonID = grade.FK_LessonID;
            LessonGradeToChange.FK_GradeID = grade.FK_GradeID;

            DiaryDbContext.Update(LessonGradeToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task RemoveAssignGradeToLesson(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var GradeToChange = await DiaryDbContext.LessonGrade.FirstOrDefaultAsync(x => x.GradeLessonID == id);

            if (GradeToChange is null)
            {
                throw new ArgumentNullException("Grade dosen't exist");
            }

            DiaryDbContext.Remove(GradeToChange);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
