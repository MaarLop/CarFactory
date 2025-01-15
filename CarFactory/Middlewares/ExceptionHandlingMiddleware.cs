using System.Text.Json;
using Microsoft.AspNetCore.Http;
namespace Modules.CarFactory.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private const string BadRequestMessage = "Bad request.";
        private const string ServerErrorMessage = "Server error.";
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ArgumentException _)
            {
                await HandleExceptionAsync(context, StatusCodes.Status400BadRequest, BadRequestMessage);
            }
            catch
            {
                await HandleExceptionAsync(context, StatusCodes.Status500InternalServerError, ServerErrorMessage);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, int statusCode, string message)
        {
            context.Response.ContentType = "application/json";
      
            var errorResponse = new
            {
                StatusCode = context.Response.StatusCode,
                Message = message
            };

            var errorJson = JsonSerializer.Serialize(errorResponse);
            return context.Response.WriteAsync(errorJson);
        }
    }

}
