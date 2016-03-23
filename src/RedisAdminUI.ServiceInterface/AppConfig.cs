using ServiceStack.Configuration;

namespace RedisAdminUI.ServiceInterface
{
	public class AppConfig
	{
		public AppConfig() {}

		public AppConfig(IAppSettings appConfig)
		{
			RedisHostAddress = appConfig.Get("RedisHostAddress", "localhost:6379");
			RedisDb = appConfig.Get("RedisDb", 0);
			DefaultRedirectPath = appConfig.Get("DefaultRedirectPath", "AjaxClient/");
		}

		public string RedisHostAddress { get; set; }
		public int RedisDb { get; set; }
		public string DefaultRedirectPath { get; set; }
	}
}