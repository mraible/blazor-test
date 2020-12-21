using System.Security.Authentication;

namespace blazor.Crosscutting.Exceptions {
    public class UserNotActivatedException : AuthenticationException {
        public UserNotActivatedException(string message) : base(message)
        {
        }
    }
}
