using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Content { get; set; }
        
        //Realtions
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public Questions? Question { get; set; }
    }
}
