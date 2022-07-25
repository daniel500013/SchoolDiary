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

        public async Task<Subject> GetSubjectById(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Subject = await DiaryDbContext.Subject.FirstOrDefaultAsync(x => x.SubjectID == id);

            if (Subject is null)
            {
                throw new ArgumentNullException("Subject dosen't exist");
            }

            return Subject;
        }

        public async Task CreateSubject(SubjectViewModel subject)
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

        public async Task PutSubject(int id, SubjectViewModel subject)
        {
            if (id.Equals(0) || subject is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var SubjectToChange = await DiaryDbContext.Subject.FirstOrDefaultAsync(x => x.SubjectID == id);

            if (SubjectToChange is null)
            {
                throw new ArgumentNullException("Subject dosen't exist");
            }

            SubjectToChange.FK_Class = subject.Class;
            SubjectToChange.FK_LessonID = subject.Lesson;
            SubjectToChange.FK_TeacherID = subject.Teacher;

            DiaryDbContext.Update(SubjectToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteSubject(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var SubjectToDelete = await DiaryDbContext.Subject.FirstOrDefaultAsync(x => x.SubjectID == id);

            if (SubjectToDelete is null)
            {
                throw new ArgumentNullException("Subject dosen't exist");
            }

            DiaryDbContext.Remove(SubjectToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
