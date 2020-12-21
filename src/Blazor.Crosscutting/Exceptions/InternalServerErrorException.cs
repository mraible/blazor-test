using blazor.Crosscutting.Constants;

namespace blazor.Crosscutting.Exceptions {
    public class InternalServerErrorException : BaseException {
        public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
        {
        }
    }
}
