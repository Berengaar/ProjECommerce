using Application.Common.Interfaces;
using Application.Common.Repositories;
using Application.Common.Repositories.BasketRepo;
using Application.Common.Repositories.BrandRepo;
using Application.Common.Repositories.CategoryRepo;
using Application.Common.Repositories.ColorRepo;
using Application.Common.Repositories.CommentRepo;
using Application.Common.Repositories.CustomerRepo;
using Application.Common.Repositories.OrderRepo;
using Application.Common.Repositories.ProductRepo;
using Infrastructure.Persistance.Repositories;
using Infrastructure.Persistance.Repositories.BasketRepo;
using Infrastructure.Persistance.Repositories.BrandRepo;
using Infrastructure.Persistance.Repositories.CategoryRepo;
using Infrastructure.Persistance.Repositories.ColorRepo;
using Infrastructure.Persistance.Repositories.CommentRepo;
using Infrastructure.Persistance.Repositories.CustomerRepo;
using Infrastructure.Persistance.Repositories.OrderRepo;
using Infrastructure.Persistance.Repositories.ProductRepo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DIContainer
{
    public static class DIServicesRegistration
    {
        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, Infrastructure.Persistance.UnitOfWork.UnitOfWork>();

            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
            services.AddScoped<IBrandReadRepository, BrandReadRepository>();
            services.AddScoped<IBrandWriteRepository, BrandWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IColorReadRepository, ColorReadRepository>();
            services.AddScoped<IColorWriteRepository, ColorWriteRepository>();
            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
