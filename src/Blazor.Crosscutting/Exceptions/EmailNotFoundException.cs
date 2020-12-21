using blazor.Crosscutting.Constants;

namespace blazor.Crosscutting.Exceptions {
    public class EmailNotFoundException : BaseException {
        public EmailNotFoundException() : base(ErrorConstants.EmailNotFoundType, "Email address not registered")
        {
        }
    }
}
