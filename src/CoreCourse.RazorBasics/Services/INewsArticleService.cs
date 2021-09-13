using CoreCourse.RazorBasics.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Services
{
    public interface INewsArticleService
    {
        Task<IEnumerable<NewsArticle>> GetNewsArticles();
    }
}
