namespace AppPortal.Core.Entities
{
    public class NewsCategory : BaseEntity<int>
    {
        public int? CategoryId { get; set; }
        public Category Categories { get; set; }
        public int? NewsId { get; set; }
        public News News { get; set; }
    }
}
