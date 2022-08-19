using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class SubjectService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public SubjectService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Subject>> GetAllSubjects()
        {
            var subjects = await DiaryDbContext.Subject.ToListAsync();

            return subjects;
        }

        public async Task<List<List<SubjectViewModel>>> GetSubjectByClass(int Class)
        {
            if (Class.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var subject = await DiaryDbContext.Subject
                .Include(x => x.Lesson)
                .Include(x => x.Teacher)
                .Where(x => x.FK_Class == Class)
                .ToListAsync();

            if (subject.Count <= 0)
            {
                throw new ArgumentNullException("Subjects dosen't exist");
            }

            var subjectViewModels = subject.Select((t, i) => new SubjectViewModel()
                {
                    Lesson = subject.Select(x => x.Lesson.Name).ToList()[i],
                    Teacher = subject.Select(x => x.Teacher.FirstName + " " + x.Teacher.LastName).ToList()[i],
                    Day = subject.Select(x => x.Lesson.Day).ToList()[i],
                    Hour = subject.Select(x => x.Lesson.Hour).ToList()[i]
                })
                .ToList();

            subjectViewModels = subjectViewModels
                .OrderBy(x => x.Day)
                .OrderBy(x => x.Hour)
                .ToList();

            var subjectViewModelsList = new List<List<SubjectViewModel>>();

            for (int i = 1; i < 6; i++)
            {
                subjectViewModelsList.Add(subjectViewModels.Where(x => x.Day == i).ToList());
            }

            return subjectViewModelsList;
        }

        public async Task CreateSubject(SubjectDto subject)
        {
            if (subject is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Subject()
            {
                FK_Class = subject.Class,
                FK_LessonID = subject.Lesson,
                FK_TeacherID = subject.Teacher
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task PutSubject(int id, SubjectDto subject)
        {
            if (id.Equals(0) || subject is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var subjectToChange = await DiaryDbContext.Subject.FirstOrDefaultAsync(x => x.SubjectID == id);

            if (subjectToChange is null)
            {
                throw new ArgumentNullException("Subject dosen't exist");
            }

            subjectToChange.FK_Class = subject.Class;
            subjectToChange.FK_LessonID = subject.Lesson;
            subjectToChange.FK_TeacherID = subject.Teacher;

            DiaryDbContext.Update(subjectToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteSubject(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var subjectToDelete = await DiaryDbContext.Subject.FirstOrDefaultAsync(x => x.SubjectID == id);

            if (subjectToDelete is null)
            {
                throw new ArgumentNullException("Subject dosen't exist");
            }

            DiaryDbContext.Remove(subjectToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
