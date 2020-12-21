using System.Security.Authentication;

namespace blazor.Crosscutting.Exceptions {
    public class UsernameNotFoundException : AuthenticationException {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
