using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TestAPI.CQRS.Commands.Products.Requests;
using TestAPI.CQRS.Commands.Products.Responses;
using TestAPI.Models;
using TestAPI.Persistance;

namespace TestAPI.CQRS.Handlers.Products.CommandHandlers
{
    public class CreateCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private InMemContext testDb;

        public CreateCommandHandler(InMemContext testDb)
        {
            this.testDb = testDb;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = testDb.Products.Add(new Product
            {
                Name = request.Name,
                Quantity = request.Quantity,
                UnitPrice = request.UnitPrice
            });

            return new CreateProductCommandResponse { Success = true };
        }
    }
}
