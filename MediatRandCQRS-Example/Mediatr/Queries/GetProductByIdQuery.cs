using MediatR;
using MediatRandCQRS_Example.Models;

namespace MediatRandCQRS_Example.Mediatr.Queries;

public class GetProductByIdQuery : IRequest<GetProductByIdViewModel>
{
    public Guid Id { get; set; }
}