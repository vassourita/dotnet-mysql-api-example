using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class Post
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Content { get; set; }
    }
}