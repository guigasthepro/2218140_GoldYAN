using GoldYAN.Areas.Identity;
using GoldYAN.Data;
using GoldYAN.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN
{
    [System.Runtime.InteropServices.Guid("57E63CA2-37BA-43F1-B1E3-2BE7B7AB47C2")]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            try 
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

                services.Configure<IdentityOptions>(option =>
                {
                    option.User.AllowedUserNameCharacters = "abcdefghijklmnopqrst1JRuYcDcmXWky8CyvW79pq1qxePi72FucuiG89- ._@+ ";
                    option.User.RequireUniqueEmail = true;
                });
            }
            catch(Exception ex)
            {

            }

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddScoped<BancosController>();
            services.AddScoped<ClassificacaoProdutosController>();
            services.AddScoped<ClientesController>();
            services.AddScoped<CodigoPostalController>();
            services.AddScoped<EncomendasController>();
            services.AddScoped<FamiliaProdutosController>();
            services.AddScoped<FornecedoresController>();
            services.AddScoped<MateriasController>();
            services.AddScoped<ModelosController>();
            services.AddScoped<MoldesController>();
            services.AddScoped<ProdutosController>();
            services.AddScoped<ProfissoesController>();
            services.AddScoped<UnidadesController>();
            services.AddScoped<ServicosController>();
            services.AddScoped<CabecalhoController>();
            services.AddScoped<CabecalhoModeloController>();
            services.AddScoped<ModelosController>();
            services.AddScoped<TipoPecaController>();
            services.AddScoped<TipoProdutoController>();
            services.AddScoped<ColaboradoresController>();
            services.AddScoped<CabecalhoProdutosController>();
            services.AddScoped<CabecalhoFabricoController>();
            services.AddScoped<FabricoController>();
            services.AddScoped<ComprasController>();
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
