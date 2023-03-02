namespace GlobalExceptionFilterExample.Exceptions;

public class RegisterUserException : Exception
{

    public RegisterUserException(string message) : base(message) { }

}