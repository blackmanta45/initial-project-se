using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SE_BackEnd.Context;
using SE_BackEnd.Mapping.Dto.MemberDtos;
using SE_BackEnd.Mapping.Dto.TransactionDtos;
using SE_BackEnd.Repositories;
using SE_BackEnd.Services;

namespace SE_BackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private readonly string _policyName = "CorsPolicy";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SE_BackEnd", Version = "v1" });
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy(_policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<ITransactionService, TransactionService>();

            services.AddTransient<AddMemberRequestProfile>();
            services.AddTransient<AddMemberResponseProfile>();
            services.AddTransient<UpdateMemberRequestProfile>();
            services.AddTransient<UpdateMemberResponseProfile>();
            services.AddTransient<AddTransactionRequestProfile>();
            services.AddTransient<AddTransactionResponseProfile>();
            services.AddTransient<GetTransactionForMemberResponseProfile>();
            services.AddTransient<TransactionProfile>();

            services.AddAutoMapper(typeof(Startup).Assembly);

            var connectionString = Configuration["AppSettings:DbConnectionString"];
            services.AddDbContext<FamilyContext>(options => options.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SE_BackEnd v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(_policyName);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
