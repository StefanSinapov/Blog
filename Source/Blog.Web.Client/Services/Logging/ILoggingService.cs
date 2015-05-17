namespace Blog.Web.Client.Services
{
    using System;

    public interface ILoggingService
    {
        void Log(Exception exception);
    }
}
