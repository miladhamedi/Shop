using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Services.Articles;
using Shop.Core.Service.Services.Categories;
using Shop.Core.Service.Services.Colors;
using Shop.Core.Service.Services.Comments;
using Shop.Core.Service.Services.Galleries;
using Shop.Core.Service.Services.Index;
using Shop.Core.Service.Services.Invoices;
using Shop.Core.Service.Services.Messages;
using Shop.Core.Service.Services.ProductColors;
using Shop.Core.Service.Services.Products;
using Shop.Core.Service.Services.Profile;
using Shop.Core.Service.Services.Role;
using Shop.Core.Service.Services.Setting;
using Shop.Core.Service.Services.ShopingCart;
using Shop.Core.Service.Services.TechnicalDetails;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserPages;
using Shop.Core.Service.Services.UserRole;
using Shop.Core.Service.Services.Weights;
using Shop.Core.Service.ServiceSender;
using Shop.Infrastructure.Data.Sql;
using Shop.Infrastructure.Data.Sql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<ShopDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("ShopConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
            {

                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                //options.Password.RequiredUniqueChars = 1;
                //options.SignIn.RequireConfirmedEmail = true;
                //options.SignIn.RequireConfirmedPhoneNumber = false;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                //options.Lockout.MaxFailedAccessAttempts = 5;
                //options.Lockout.AllowedForNewUsers = true;


            })
                .AddEntityFrameworkStores<ShopDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            services.AddMemoryCache();
            services.AddSession();


            #region Register Repository
            services.AddScoped<ISettingRepository, SettingRepository>();
            services.AddScoped<IGalleryRepository, GalleryRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductIndexRepository, ProductIndexRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ITechnicalDetailRepository, TechnicalDetailRepository>();
            services.AddScoped<IUserRepositroy, UserRepositroy>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IinvoiceRepository, InvoiceRepository>();
            services.AddScoped<IProductColorRepository, ProductColorRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
            services.AddScoped<IWeightRepository, WeightRepository>();
            services.AddScoped<IUserPageRepository, UserPageRepository>();
            #endregion

            #region Register Service
            services.AddScoped<IUserPageService, UserPageService>();
            services.AddScoped<ITechnicalDetailService, TechnicalDetailService>();
            services.AddScoped<IWeightService, WeightService>();
            services.AddScoped<IGalleryService, GalleryService>();
            services.AddScoped<IShopingCartService,ShopingCartService>();
            services.AddScoped<IEmailSender, MessageSender>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductIndexService, ProductIndexService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IinvoiceService, InvoiceService>();
            services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<IProfileIndexService, ProfileIndexService>();
            services.AddScoped<IProductColorService, ProductColorService>();
            services.AddScoped<IRoleService, RoleService>();

            #endregion



        }






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            loggerFactory.AddFile("Logs/Shop-{Date}.txt");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                 );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
