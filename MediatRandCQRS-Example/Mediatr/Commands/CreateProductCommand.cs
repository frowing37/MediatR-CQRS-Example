using MediatR;

namespace MediatRandCQRS_Example.Mediatr.Commands;

public class CreateProductCommand : IRequest<Guid>
{
    public string Name { get; set; }
    
    public int Quantity { get; set; }
    
    public decimal Value { get; set; }
} 