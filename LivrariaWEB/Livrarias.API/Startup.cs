using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Livraria.Dominio.Base;
using Livraria.Dominio.Livros;

namespace Livrarias.API
{
    public class Startup
    {
        public IConfiguration Configuracao { get; set; }

        public Startup(IHostingEnvironment enviroment)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(enviroment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuracao = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors();

            services.AddScoped<LivrariaContexto, LivrariaContexto>();
            services.AddTransient<IUow, Uow>();
            services.AddTransient<ILivroRepository, LivroRepository>();
            services.AddTransient<ILivroServico, LivroServico>();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });

            app.UseMvc();

            Runtime.ConnectionString = Configuracao.GetConnectionString("CnnStr");
        }
    }
}
