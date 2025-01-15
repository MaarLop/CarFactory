namespace Modules.CarFactory.Middlewares
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TimerMiddleware> _logger;

        public TimerMiddleware(RequestDelegate next, ILogger<TimerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
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
                _logger.LogInformation($"Request finish after {stopwatch.ElapsedMilliseconds.ToString()} ms");
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