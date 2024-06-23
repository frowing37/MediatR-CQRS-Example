using MediatR;
using MediatRandCQRS_Example.Mediatr.Queries;
using MediatRandCQRS_Example.Models;

namespace MediatRandCQRS_Example.Mediatr.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
{
    public async Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var viewModel = new GetProductByIdViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Book"
        };

        return await Task.FromResult(viewModel);
    }
}