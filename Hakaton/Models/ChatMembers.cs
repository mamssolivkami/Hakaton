using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hakaton.Models
{
    public class ChatMembers
    {
        public int Id { get; set; }
        public IdentityUser User_ { get; set; }
        public Chat Chat_ { get; set; }
    }
}
