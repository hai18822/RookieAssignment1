namespace AssigmentMVC.Middlewares
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}