using Application.Common.Interfaces;
using Application.Common.Repositories.BasketRepo;
using Application.Common.Repositories.BrandRepo;
using Application.Common.Repositories.CategoryRepo;
using Application.Common.Repositories.ColorRepo;
using Application.Common.Repositories.CommentRepo;
using Application.Common.Repositories.CustomerRepo;
using Application.Common.Repositories.OrderRepo;
using Application.Common.Repositories.ProductRepo;
using Infrastructure.Persistance.Contexts;
using Infrastructure.Persistance.Repositories.BasketRepo;
using Infrastructure.Persistance.Repositories.BrandRepo;
using Infrastructure.Persistance.Repositories.CategoryRepo;
using Infrastructure.Persistance.Repositories.ColorRepo;
using Infrastructure.Persistance.Repositories.CommentRepo;
using Infrastructure.Persistance.Repositories.CustomerRepo;
using Infrastructure.Persistance.Repositories.OrderRepo;
using Infrastructure.Persistance.Repositories.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjECommerceDbContext _context;
        private ProductReadRepository _productReadRepository;
        private ProductWriteRepository _productWriteRepository;
        private CategoryReadRepository _categoryReadRepository;
        private CategoryWriteRepository _categoryWriteRepository;
        private BrandReadRepository _brandReadRepository;
        private BrandWriteRepository _brandWriteRepository;
        private BasketReadRepository _basketReadRepository;
        private BasketWriteRepository _basketWriteRepository;
        private ColorReadRepository _colorReadRepository;
        private ColorWriteRepository _colorWriteRepository;
        private CommentReadRepository _commentReadRepository;
        private CommentWriteRepository _commentWriteRepository;
        private CustomerReadRepository _customerReadRepository;
        private CustomerWriteRepository _customerWriteRepository;
        private OrderReadRepository _orderReadRepository;
        private OrderWriteRepository _orderWriteRepository;
        public UnitOfWork(ProjECommerceDbContext context)
        {
            _context = context;
        }

        public IBasketReadRepository BasketReadRepository => _basketReadRepository ?? (_basketReadRepository = new BasketReadRepository(_context));

        public IBrandReadRepository BrandReadRepository => _brandReadRepository ?? (_brandReadRepository = new BrandReadRepository(_context));

        public ICategoryReadRepository CategoryReadRepository => _categoryReadRepository ?? (_categoryReadRepository = new CategoryReadRepository(_context));

        public IColorReadRepository ColorReadRepository => _colorReadRepository ?? (_colorReadRepository = new ColorReadRepository(_context));

        public ICommentReadRepository CommentReadRepository => _commentReadRepository ?? (_commentReadRepository = new CommentReadRepository(_context));

        public ICustomerReadRepository CustomerReadRepository => _customerReadRepository ?? (_customerReadRepository = new CustomerReadRepository(_context));

        public IOrderReadRepository OrderReadRepository => _orderReadRepository ?? (_orderReadRepository = new OrderReadRepository(_context));

        public IProductReadRepository ProductReadRepository => _productReadRepository ?? (_productReadRepository = new ProductReadRepository(_context));

        public IBasketWriteRepository BasketWriteRepository => _basketWriteRepository ?? (_basketWriteRepository = new BasketWriteRepository(_context));

        public IBrandWriteRepository BrandWriteRepository => _brandWriteRepository ?? (_brandWriteRepository = new BrandWriteRepository(_context));

        public ICategoryWriteRepository CategoryWriteRepository => _categoryWriteRepository ?? (_categoryWriteRepository = new CategoryWriteRepository(_context));

        public IColorWriteRepository ColorWriteRepository => _colorWriteRepository ?? (_colorWriteRepository = new ColorWriteRepository(_context));

        public ICommentWriteRepository CommentWriteRepository => _commentWriteRepository ?? (_commentWriteRepository = new CommentWriteRepository(_context));

        public ICustomerWriteRepository CustomerWriteRepository => _customerWriteRepository ?? (_customerWriteRepository = new CustomerWriteRepository(_context));

        public IOrderWriteRepository OrderWriteRepository => _orderWriteRepository ?? (_orderWriteRepository = new OrderWriteRepository(_context));

        public IProductWriteRepository ProductWriteRepository => _productWriteRepository ?? (_productWriteRepository = new ProductWriteRepository(_context));

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
