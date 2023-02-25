using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }

        [Display(Name = "Giá nhập")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Số lượng tồn")]
        public int Stock { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { set; get; }

        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Chi tiết")]
        public string Details { set; get; }

        public string SeoDescription { set; get; }

        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }

        public string LanguageId { set; get; }

        public bool? IsFeatured { get; set; }

        [Display(Name = "Chèn ảnh")]
        public IFormFile ThumbnailImage { get; set; }
    }
}