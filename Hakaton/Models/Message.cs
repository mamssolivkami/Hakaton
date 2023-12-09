using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hakaton.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IdentityUser Sender_ { get; set; }
        public Chat Chat_ { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
