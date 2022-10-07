using Microsoft.AspNetCore.Http;
using System.Diagnostics;
namespace AssigmentMVC.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            string requestInfo = "Scheme: " + request.Scheme +
            "\t Host: " + request.Host +
            "\t Path: " + request.Path +
            "\t Query String: " + request.QueryString +
            "\t Request Body: " + request.Body;

            Debug.Write(requestInfo);
            File.WriteAllText("D:\\texttinformation.txt", requestInfo);

            await _next(context);
        }
    }
}