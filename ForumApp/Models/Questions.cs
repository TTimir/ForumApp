using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        //Relations
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public List<Answers>? Answers { get; set; }
    }
}
