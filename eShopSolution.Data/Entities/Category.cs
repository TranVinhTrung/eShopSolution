using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id {set; get;}
        public int SortOrder {set; get;}
        public bool IsShowOnHome {set; get;}
        public int? ParenId {set; get;}
        public Status Status {set; get;} 
    }
}
