using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategory")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Allias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public int? ParentId { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Post> Post { set; get; }
    }
}