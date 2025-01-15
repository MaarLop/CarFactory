namespace Modules.CarFactory.Middlewares
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;

        public TimerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var originalBodyStream = context.Response.Body;
            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            try
            {
                await _next(context);

                stopwatch.Stop();

                context.Response.Headers["X-Elapsed-Time-ms"] = stopwatch.ElapsedMilliseconds.ToString();

                memoryStream.Seek(0, SeekOrigin.Begin);
                await memoryStream.CopyToAsync(originalBodyStream);
            }
            finally 
            { 
                context.Response.Body = originalBodyStream;
            }
        }
    }
}