using blazor.Crosscutting.Constants;

namespace blazor.Crosscutting.Exceptions {
    public class InvalidPasswordException : BaseException {
        public InvalidPasswordException() : base(ErrorConstants.InvalidPasswordType, "Incorrect Password")
        {
            //Status = StatusCodes.Status400BadRequest
        }
    }
}
