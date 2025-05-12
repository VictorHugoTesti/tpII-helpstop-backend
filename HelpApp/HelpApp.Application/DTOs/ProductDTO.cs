using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpApp.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Invalid name, name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]

        public string Name { get; set; }


        [Required(ErrorMessage = "Invalid description, descripition is required")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "The price is requerid")]
        [Column(TypeName = "decimal (18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal price { get; set; }


        [Required(ErrorMessage ="The stock is required")]
        [Range(1, 9999)]
        [DisplayName("Stock")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Invalid image name, too long, maximum 250 characteres")]
        [MaxLength(250)]
        [DisplayName("Image")]
        public string image { get; set; }

        
    }
}
