using blazor.Crosscutting.Constants;

namespace blazor.Crosscutting.Exceptions {
    public class EmailAlreadyUsedException : BadRequestAlertException {
        public EmailAlreadyUsedException() : base(ErrorConstants.EmailAlreadyUsedType, "Email is already in use!",
            "userManagement", "emailexists")
        {
        }
    }
}
