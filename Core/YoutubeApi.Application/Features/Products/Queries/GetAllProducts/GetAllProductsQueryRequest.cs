using MediatR;

namespace YoutubeApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {
    }
}
