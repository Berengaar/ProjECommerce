using Application.Common.Repositories.BasketRepo;
using Application.Common.Repositories.BrandRepo;
using Application.Common.Repositories.CategoryRepo;
using Application.Common.Repositories.ColorRepo;
using Application.Common.Repositories.CommentRepo;
using Application.Common.Repositories.CustomerRepo;
using Application.Common.Repositories.OrderRepo;
using Application.Common.Repositories.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        IBasketReadRepository BasketReadRepository { get; }
        IBrandReadRepository BrandReadRepository { get; }
        ICategoryReadRepository CategoryReadRepository { get; }
        IColorReadRepository ColorReadRepository { get; }
        ICommentReadRepository CommentReadRepository { get; }
        ICustomerReadRepository CustomerReadRepository { get; }
        IOrderReadRepository OrderReadRepository { get; }
        IProductReadRepository ProductReadRepository { get; }


        IBasketWriteRepository BasketWriteRepository { get; }
        IBrandWriteRepository BrandWriteRepository { get; }
        ICategoryWriteRepository CategoryWriteRepository { get; }
        IColorWriteRepository ColorWriteRepository { get; }
        ICommentWriteRepository CommentWriteRepository { get; }
        ICustomerWriteRepository CustomerWriteRepository { get; }
        IOrderWriteRepository OrderWriteRepository { get; }
        IProductWriteRepository ProductWriteRepository { get; }

       

    }
}
