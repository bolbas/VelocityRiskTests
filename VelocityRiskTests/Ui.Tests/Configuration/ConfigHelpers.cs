using Microsoft.Extensions.Configuration;

namespace Ui.Configuration
{
    public static class ConfigHelpers
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static UIConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new UIConfiguration();

            var iConfig = GetIConfigurationRoot(outputPath);

            iConfig
                .GetSection("TestSettings")
                .Bind(configuration);

            return configuration;
        }
    }
}
