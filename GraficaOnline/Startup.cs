using GraficaOnline.Areas.Admin.Servicos;
using GraficaOnline.Context;
using GraficaOnline.Models;
using GraficaOnline.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReflectionIT.Mvc.Paging;

namespace GraficaOnline
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Home/AccessDenied");

            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            services.AddScoped<RelatorioVendasService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(cp => CarrinhoCompra.GetCarrinho(cp));
            services.AddControllersWithViews();

            services.AddPaging(options => {
                options.ViewName = "Bootstrap4";
                options.PageParameterName = "pageindex";
            });

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                   name: "AdminArea",
                   pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "categoriaFiltro",
                   pattern: "Produto/{action}/{categoria?}",
                   defaults: new { Controller = "Produto", action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
