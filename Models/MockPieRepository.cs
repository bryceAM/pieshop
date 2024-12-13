namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => 
            new List<Pie>
            {
                new Pie { PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="sdlfkjsdl;fjs sdf;lasjdfl; sldk;jfsdlkfjds;l.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg", InStock=true,IsPieOfTheWeek=false, ImageThumbnailUrl="https://"}

                //        public int PieId { get; set; }
                //public string Name { get; set; } = string.Empty;
                //public string? ShortDescription { get; set; }
                //public string? LongDescription { get; set; }
                //public string? AllergyInformation { get; set; }
                //public decimal Price { get; set; }
                //public string? ImageUrl { get; set; }
                //public string? ImageThumbnailUrl { get; set; }
                //public bool IsPieOfTheWeek { get; set; }
                //public bool InStock { get; set; }
                //public int CategoryId { get; set; }
                //public Category Category { get; set; } = default!;
            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
