using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace InputAnalysis
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

            var service = new Services.InputAnalysisService();

            var storedText = File.ReadAllText("InputFile/Input.txt");

            (var doubleRes, var stringRes) = service.ProcessInput(storedText);

            Console.WriteLine($"Sum: {doubleRes.Sum()}" );
            Console.WriteLine($"Average: {doubleRes.Average()}");
            Console.WriteLine($"Median: {doubleRes.OrderBy(x => x).ElementAt(doubleRes.Count/2)}");
            Console.WriteLine($"_______________");
            Console.WriteLine($"{doubleRes.Count/(doubleRes.Count + stringRes.Count)}% of values were numbers");
            Console.WriteLine($"_______________");
            Console.WriteLine($"Distinct, reverse alphabetized list:");
            
            //using a looping writeLine here for cleanliness of output
            foreach(var s in stringRes.Distinct().OrderByDescending(x => x))
            {
                Console.WriteLine(s);
            }


            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "InputAnalysis",
                    Description = "InputAnalysis"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "InputAnalysis API V1");
            });
        }
    }
}
