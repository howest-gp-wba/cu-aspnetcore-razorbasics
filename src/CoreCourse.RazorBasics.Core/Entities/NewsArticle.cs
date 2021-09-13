﻿using System;

namespace CoreCourse.RazorBasics.Core.Entities
{
    public class NewsArticle
    {
        public int Id { get; set; }

        public DateTimeOffset CreationDate { get; set; }

        public bool IsPublished { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

    }
}
