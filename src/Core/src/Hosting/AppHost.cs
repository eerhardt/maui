#nullable enable

namespace Microsoft.Maui.Hosting
{
	public static class AppHost
	{
		public static IAppHostBuilder CreateDefaultBuilder()
		{
			var builder = new AppHostBuilder();

			builder.UseMauiServiceProviderFactory(false);

			builder.UseMauiHandlers();
			builder.ConfigureFonts();

			return builder;
		}
	}
}