using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class News
    {
        public int Id { get; set; }
        
        public string Title { get; set; }  = string.Emty;
        [Maxlength(200)]
        [Minlength(20)]
        [Require]

       [System.ComponentModel.Bindable(true)]
        public virtual string ImageUrl { get; set; } = string.Emty;
        public string Content  { get; set; }
        [Maxlength(500)]
        [Minlength(100)]
        [Require]

        public string Author { get; set; }  = string.Emty;
        
        [Require]

        public string CreatedAt { get; set; }
          

    }
}