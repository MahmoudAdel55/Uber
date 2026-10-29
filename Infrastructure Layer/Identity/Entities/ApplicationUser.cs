using Microsoft.AspNetCore.Identity;

namespace Domain_Layer.Entities.Identity
{
    internal class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; } = default!;
    }
}
