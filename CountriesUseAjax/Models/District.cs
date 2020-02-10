using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesUseAjax.Models
{
    [Table("Districts")]
    public class District
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Code { get; set; }
        
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        //Hai thằng này phải đi vs nhau khi tạo khóa chính khóa ngoại
        [StringLength(50)]
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Provinces { get; set; }
    }
}
