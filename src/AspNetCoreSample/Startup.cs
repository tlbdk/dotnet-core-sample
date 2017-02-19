using AspNetCoreSample.DbModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;

namespace AspNetCoreSample
{
    public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase());
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);
            
            if (env.IsDevelopment())
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    // Create some test data
                    using(var context = serviceScope.ServiceProvider.GetService<DatabaseContext>()) {
                         context.Users.Add(new User() {
                            FirstName = "Test",
                            LastName = "Testsen",
                            Email = "test@testsen.com",
                            IdCards = new List<IdCard> {
                                new IdCard { 
                                    Ssn = "123456781234"
                                }
                            }
                        });
                        context.SaveChanges();
                    }
                }
            }

            app.UseMvc();
        }
    }
}