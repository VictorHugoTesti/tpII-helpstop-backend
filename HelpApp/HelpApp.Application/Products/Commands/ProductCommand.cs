using MediatR;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Products.Commands
{
    public class ProductCommand : IRequest<Product>
    {
        public sbyte Nome { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}
