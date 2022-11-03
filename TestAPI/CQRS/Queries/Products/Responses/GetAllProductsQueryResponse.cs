namespace TestAPI.CQRS.Queries.Products.Responses
{
    public class GetAllProductsQueryResponse
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
