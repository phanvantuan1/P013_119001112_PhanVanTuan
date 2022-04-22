using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        
        [Require]

        public string Content  { get; set; }
         
        [Require]

        public string CreatedAt { get; set; }
        

       
    }
}