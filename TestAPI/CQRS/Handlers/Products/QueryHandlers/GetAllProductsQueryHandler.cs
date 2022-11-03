using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestAPI.CQRS.Queries.Products.Requests;
using TestAPI.CQRS.Queries.Products.Responses;
using TestAPI.Persistance;

namespace TestAPI.CQRS.Handlers.Products.QueryHandlers
{
    public class GetAllProductsQueryHandler:IRequestHandler<GetAllProductsQueryRequest, List<GetAllProductsQueryResponse>>
    {
        private InMemContext testDb;

        public GetAllProductsQueryHandler(InMemContext testDb)
        {
            this.testDb = testDb;
        }

        public async Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var result = testDb.Products.Select(x => new GetAllProductsQueryResponse
            {
                Name = x.Name,
                Quantity = x.Quantity,
                UnitPrice = x.UnitPrice
            }).ToList();

            return result;
        }
    }
}
