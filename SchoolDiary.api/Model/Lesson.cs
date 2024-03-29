﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Lesson
    {
        public int LessonID { get; set; }
        public string? Name { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_LessonID")]
        public ICollection<Subject>? Subjects { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_LessonID")]
        public ICollection<LessonMark>? LessonMarks { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_LessonID")]
        public ICollection<LessonGrade>? LessonGrades { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_LessonID")]
        public ICollection<LessonApprove>? LessonApproves { get; set; }
    }
}
