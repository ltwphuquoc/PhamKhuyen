namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Display(Name ="ID")]
        public int proID { get; set; }
        [Display(Name = "ID Loai Sản phẩm")]
        public int? CateID { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage ="Chưa nhập tên sản phẩm")]
        [StringLength(70)]
        public string Name { get; set; }
        [Display(Name = "Đơn giá")]
        [Required(ErrorMessage = "Chưa nhập đơn giá")]
        public decimal UnitCost { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Chưa nhập số lượng")]
        public int quantity { get; set; }
        [Display(Name = "Mô tả")]
        [StringLength(150)]
        public string Description { get; set; }
        [Display(Name = "Trạng thái")]
        [StringLength(30)]
        public string Status { get; set; }
        [Display(Name = "Hình ảnh")]
        public string img { get; set; }

        public virtual Category Category { get; set; }
    }
}
