using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Game
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string? Name{ get; set; }
        [Required(ErrorMessage = "Developer is Required")]
        public string? Developer { get; set; }
        [Required(ErrorMessage = "Publisher is Required")]
        public string? Publisher{ get; set; }
        [Range(1950,2024,ErrorMessage ="Release Date must be between 1950 and 2024")]
        [Required(ErrorMessage = "Release Date is Required")]
        public int? ReleaseDate { get; set; }
        [Required(ErrorMessage = "Type is Required")]
        public string? Type { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        [Range(0,100000, ErrorMessage = "Price must be between 0 and 100000")]
        public decimal? Price { get; set; }
        //[Required(ErrorMessage = "Image File is Required")]
        public string? ImageFileName { get; set; }

        public string Slug => $"{Name}-{Developer}".ToLower().Replace(" ","-");
		public string DisplayName => Name.Trim().Replace("_", " ");
	}
}
