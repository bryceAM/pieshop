namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; set; }
        Pie? GetPieById(int pieId);
    }
}
