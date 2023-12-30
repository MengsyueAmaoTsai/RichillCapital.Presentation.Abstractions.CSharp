using Microsoft.AspNetCore.Mvc;

namespace RichillCapital.Presentation.Abstractions.AspNetCore;

public static class AsyncEndpoint
{
    public static class WithRequest<TRequest>
    {
        public abstract class WithResponse<TResponse> : EndpointBase
        {
            public abstract Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
        }

        public abstract class WithoutResponse : EndpointBase
        {
            public abstract Task HandleAsync(TRequest request, CancellationToken cancellationToken = default);
        }

        public abstract class WithActionResult<TResponse> : EndpointBase
        {
            public abstract Task<ActionResult<TResponse>> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
        }

        public abstract class WithActionResult : EndpointBase
        {
            public abstract Task<ActionResult> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
        }

        public abstract class WithAsyncEnumerableResult<T> : EndpointBase
        {
            public abstract IAsyncEnumerable<T> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
        }
    }

    public static class WithoutRequest
    {
        public abstract class WithResponse<TResponse> : EndpointBase
        {
            public abstract Task<TResponse> HandleAsync(CancellationToken cancellationToken = default);
        }

        public abstract class WithoutResponse : EndpointBase
        {
            public abstract Task HandleAsync(CancellationToken cancellationToken = default);
        }

        public abstract class WithActionResult<TResponse> : EndpointBase
        {
            public abstract Task<ActionResult<TResponse>> HandleAsync(CancellationToken cancellationToken = default);
        }

        public abstract class WithActionResult : EndpointBase
        {
            public abstract Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default);
        }

        public abstract class WithAsyncEnumerableResult<T> : EndpointBase
        {
            public abstract IAsyncEnumerable<T> HandleAsync(CancellationToken cancellationToken = default);
        }
    }
}