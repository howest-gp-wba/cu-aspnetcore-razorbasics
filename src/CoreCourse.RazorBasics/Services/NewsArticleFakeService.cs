﻿using CoreCourse.RazorBasics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.RazorBasics.Services
{
    /// <summary>
    /// Simulates a service which grabs NewsArticle objects from a datasource.
    /// But in fact, these articles are stored in memory
    /// </summary>
    public class NewsArticleFakeService : INewsArticleService
    {
        public async Task<IEnumerable<NewsArticle>> GetNewsArticles()
        {
            await Task.Delay(0);
            return new List<NewsArticle>
            {
                new NewsArticle
                {
                    Id = 1, CreationDate = DateTime.Now.AddDays(-10), Author = "S. Derdeyn", IsPublished = true,
                    Title = "Introducing ASP.NET Core",
                    Content = @"
ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications. With ASP.NET Core, you can:
<ul>
    <li>Build web apps and services, IoT apps, and mobile backends.</li>
    <li>Use your favorite development tools on Windows, macOS, and Linux.</li>
    <li>Deploy to the cloud or on-premises.</li>
    <li>Run on .NET Core or .NET Framework.</li>
</ul>
"
                },
                new NewsArticle
                {
                    Id = 2, CreationDate = DateTime.Now.AddDays(-6), Author = "S. Derdeyn", IsPublished = true,
                    Title = ".NET 6 is here!",
                    Content = @"
<p>Download .NET 6.0</p>
<p>Head over to <a href=""https://dotnet.microsoft.com/en-us/download/dotnet/6.0\"">this page</a>.</p>
"
                },
                new NewsArticle
                {
                    Id = 3, CreationDate = DateTime.Now.AddDays(-5), Author = "S. Derdeyn", IsPublished = true,
                    Title = "Did you browse the ASP.NET Core Sources yet?",
                    Content = @"
<p>As you might know, ASP.NET Core is completely open source. Everything can be found on github.</p>
<p>This includes the source code of the ASP.NET Core packages.</p>
<p>Why don't you go over to <a href=""https://github.com/dotnet/aspnetcore"">github and have a look</a>!</p>
"
                }
            };
        }
    }
}
