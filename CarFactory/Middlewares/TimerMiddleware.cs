using Modules.CarFactory.Middlewares;

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
            // Medir el tiempo de inicio
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            // Guardar el cuerpo de la respuesta en un buffer temporal
            var originalBodyStream = context.Response.Body;
            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            try
            {
                // Ejecutar el pipeline
                await _next(context);

                // Detener el temporizador
                stopwatch.Stop();

                // Agregar el encabezado con el tiempo transcurrido
                context.Response.Headers["X-Elapsed-Time-ms"] = stopwatch.ElapsedMilliseconds.ToString();

                // Revertir el buffer y enviar la respuesta al cliente
                memoryStream.Seek(0, SeekOrigin.Begin);
                await memoryStream.CopyToAsync(originalBodyStream);
            }
            finally
            {
                // Restaurar el stream original
                context.Response.Body = originalBodyStream;
            }
        }
    }
}

