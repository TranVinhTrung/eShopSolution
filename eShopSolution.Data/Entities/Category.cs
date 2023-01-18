using eShopSolution.Data.Enums;
using System.Collections.Generic;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id {set; get;}
        public int SortOrder {set; get;}
        public bool IsShowOnHome {set; get;}
        public int? ParenId {set; get;}
        public Status Status {set; get;}

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
