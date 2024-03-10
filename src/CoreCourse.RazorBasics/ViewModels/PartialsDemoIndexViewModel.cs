using CoreCourse.RazorBasics.Core.Entities;
using System.Collections.Generic;

namespace CoreCourse.RazorBasics.ViewModels
{
    public class PartialsDemoIndexViewModel
    {
        public IEnumerable<NewsArticle> NewsArticles { get; set; }
    }
}
