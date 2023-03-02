using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GlobalExceptionFilterExample.Exceptions;

public class GlobalExceptionFilter : IExceptionFilter
{

    public void OnException(ExceptionContext context)
    {

        if (context.Exception is RegisterUserException)
        {
            context.Result = new BadRequestObjectResult("Kayıt işlemi sırasında bir hata oluştu.");
        }

        else if (context.Exception is PaymentException)
        {
            context.Result = new BadRequestObjectResult("Ödeme işlemi sırasında bir hata oluştu.");
        }

        else if (context.Exception is LoginException)
        {
            context.Result = new BadRequestObjectResult("Giriş işlemi sırasında bir hata oluştu.");
        }

        else
        {
            context.Result = new StatusCodeResult(500);
        }

        context.ExceptionHandled = true;

    }

}