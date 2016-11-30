namespace AppPrincipale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesLT.Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal StandardCost { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        public decimal? Weight { get; set; }

        [Column("ProductCategoryID")]
        public int? CategoryID { get; set; }

        public int? ProductModelID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,  DataFormatString = "yyyy-MM-dd")]
        public DateTime SellStartDate { get; set; }

        [DataType(DataType.Date)]      
        [UIHint("DateRouge")]
        public DateTime? SellEndDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DiscontinuedDate { get; set; }

        [ScaffoldColumn(false)]
        public byte[] ThumbNailPhoto { get; set; }

        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        public Guid rowguid { get; set; }

        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
