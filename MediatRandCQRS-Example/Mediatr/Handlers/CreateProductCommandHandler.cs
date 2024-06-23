using MediatR;
using MediatRandCQRS_Example.Mediatr.Commands;

namespace MediatRandCQRS_Example.Mediatr.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //entity is sent to db with service
        return await Task.FromResult(Guid.NewGuid());
    }
}