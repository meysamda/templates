namespace Test22.Infrastructure.Data.Repositories
{
    public interface IPagableFilter : IFilter
    {
        int? Skip { get; set; }
        int? Limit { get; set; }
        string Sort { get; set; }
    }
}
