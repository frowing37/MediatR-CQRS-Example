using MediatR;
using MediatRandCQRS_Example.Mediatr.Queries;
using MediatRandCQRS_Example.Models;

namespace MediatRandCQRS_Example.Mediatr.Handlers;

public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdViewModel>>
{
    public async Task<List<GetProductByIdViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var viewModel = new GetProductByIdViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Book"
        };

        return await Task.FromResult(new List<GetProductByIdViewModel>() { viewModel });
    }
}