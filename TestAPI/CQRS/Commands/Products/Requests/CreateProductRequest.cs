using MediatR;
using TestAPI.CQRS.Commands.Products.Responses;

namespace TestAPI.CQRS.Commands.Products.Requests
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
