using MediatR;
using System.Collections.Generic;
using TestAPI.CQRS.Queries.Products.Responses;

namespace TestAPI.CQRS.Queries.Products.Requests
{
    public class GetAllProductsQueryRequest:IRequest<List<GetAllProductsQueryResponse>>
    {

    }
}
