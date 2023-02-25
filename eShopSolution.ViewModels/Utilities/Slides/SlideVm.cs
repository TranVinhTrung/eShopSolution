using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Utilities.Slides
{
    public class SlideVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { set; get; }

        public string Url { set; get; }

        public string Image { get; set; }

        public int SortOrder { set; get; }
    }
}