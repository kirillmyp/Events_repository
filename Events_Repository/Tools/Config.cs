namespace Events_Repository.Tools
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public static class Config
    {
        public static IConfigurationRoot  GetConfig()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
        }
    }
}
