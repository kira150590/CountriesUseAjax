using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesUseAjax.Models
{
    [Table("Wards")]
    public class Ward
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Code { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District Districts { get; set; }
    }
}
