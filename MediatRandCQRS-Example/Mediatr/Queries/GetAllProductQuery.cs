using MediatR;
using MediatRandCQRS_Example.Models;

namespace MediatRandCQRS_Example.Mediatr.Queries;

public class GetAllProductQuery : IRequest<List<GetProductByIdViewModel>>
{
    
}