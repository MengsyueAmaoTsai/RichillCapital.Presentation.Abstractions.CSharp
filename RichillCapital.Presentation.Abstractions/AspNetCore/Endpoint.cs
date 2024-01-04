using Microsoft.AspNetCore.Mvc;

using RichillCapital.Extensions.Primitives;

namespace RichillCapital.Presentation.Abstractions.AspNetCore;

[ApiController]
public abstract class EndpointBase : ControllerBase
{
    protected ActionResult HandleFailure(Error error)
    {
        return error.Type switch
        {
            ErrorType.Invalid => BadRequest(error.Message),
            ErrorType.NotFound => NotFound(error.Message),
            ErrorType.Conflict => BadRequest(error.Message),
            ErrorType.Unauthorized => Unauthorized(error.Message),
            ErrorType.Default => throw new NotImplementedException(),
            ErrorType.Null => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };
    }
}