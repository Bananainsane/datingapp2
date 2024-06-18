using System.Threading.Tasks;

namespace DatingApp.Services
{
    public class UserService
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public bool IsLoggedIn { get; set; }

        public async Task LogoutAsync()
        {
            // Simulate an async logout process (e.g., clearing tokens, notifying server, etc.)
            await Task.Delay(100); // Simulate some async work
            IsLoggedIn = false;
        }
    }
}
