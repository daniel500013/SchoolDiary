﻿using System;

namespace SchoolDiary.api.Dto
{
    public class MarkManagerDto
    {
        public string? LessonName { get; set; }
        public bool Present { get; set; }
        public DateTime? Data { get; set; }
    }
}
