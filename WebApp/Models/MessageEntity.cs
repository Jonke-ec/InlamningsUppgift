using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class MessageEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string? ImageUrl { get; set; }
    }
}
