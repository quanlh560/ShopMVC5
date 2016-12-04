using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Department { set; get; }

        [MaxLength(50)]
        [Required]
        public string Email { set; get; }

        [MaxLength(50)]
        public string Skype { set; get; }

        public bool? Status { set; get; }
    }
}