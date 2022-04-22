using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDataComment
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
                    new Comment
                    {
                       Title = "When Harry Met Sally",
                       ImageUrl = ,
                       
                
                       Content = "Romantic Comedy",
                       Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                        
                    },

                   

                    
                    new  Comment
                    {
                       Title = "When Harry Met Sally",
                       ImageUrl = ,
                       
                
                       Content = "Romantic Comedy",
                       Author = "PhanVanTuan",
                        CreatedAt = 7.99M
                        
                    }
                    
                );
                context.SaveChanges();
            }
        }
    }
}