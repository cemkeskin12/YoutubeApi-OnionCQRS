using FluentValidation;

namespace YoutubeApi.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommandRequest>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
