using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDataNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                   new News
                    {
                        
                        Content  = "Romantic Comedy",
                        Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                       
                    },

                    new  News
                    {
                        Content  = "Romantic Comedy",
                        Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                        
                    },

                    new  News
                    {
                        Content  = "Romantic Comedy",
                        Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                        
                    },

                    new  News
                    {
                        Content  = "Romantic Comedy",
                        Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                        
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}