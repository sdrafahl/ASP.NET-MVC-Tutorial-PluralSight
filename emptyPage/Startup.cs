using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace emptyPage
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if(env.IsEnvironment("Development")){
                 app.UseDeveloperExceptionPage(); 
            }
            
            //app.UseDefaultFiles();//inital setup
           
            app.UseStaticFiles();//require this during inital setup "Microsoft.AspNetCore.StaticFiles": "1.0.0-rc2-final"
           /*Required in this order for index.html to be default page */
            app.UseMvc(config =>
                {
                    config.MapRoute(
                        name: "Default",
                        template:"{controller}/{action}/{id?}",
                        defaults: new {controller = "App", action="Index"}
                    );

                    
                }
            
            );
        }
    }
}
