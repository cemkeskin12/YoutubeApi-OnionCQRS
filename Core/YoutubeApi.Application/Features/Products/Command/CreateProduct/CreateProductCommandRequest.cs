using MediatR;

namespace YoutubeApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest<Unit>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public IList<int> CategoryIds { get; set; }
    }
}
