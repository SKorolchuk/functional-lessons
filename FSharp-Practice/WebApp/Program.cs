using Microsoft.AspNet.Builder;

namespace WebApp
{
   	public class StartUp
	{
		public void Configuration(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}
