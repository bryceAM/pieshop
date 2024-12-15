namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie { PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="sdlfkjsdl;fjs sdf;lasjdfl; sldk;jfsdlkfjds;l.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg", InStock=true,IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg"},
                new Pie { PieId = 2, Name="Cheese Cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="sdlfkjsdl;fjs sdf;lasjdfl; sldk;jfsdlkfjds;l.", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg", InStock=true,IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg"},
                new Pie { PieId = 3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="sdlfkjsdl;fjs sdf;lasjdfl; sldk;jfsdlkfjds;l.", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpiesmall.jpg", InStock=true,IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpiesmall.jpg"},
                new Pie { PieId = 4, Name="Pumpkin Pie", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="sdlfkjsdl;fjs sdf;lasjdfl; sldk;jfsdlkfjds;l.", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpiesmall.jpg", InStock=true,IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpiesmall.jpg"}
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
