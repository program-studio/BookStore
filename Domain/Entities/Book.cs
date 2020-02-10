using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "ID")]
        public int BookId { get; set; }

        [Display(Name= "Names")]
        [Required(ErrorMessage ="Please, enter name of book")]
        public string Name { get; set; }

        [Display(Name = "Author")]
        [Required(ErrorMessage = "Please, enter name of author")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please, enter description of book")]
        public string Description { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please, enter genre of book")]
        public string Genre { get; set; }

        [Display(Name = "Price (USD)")]
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage = "Please, enter correct price")]
        public decimal Price { get; set; }

        [Display(Name = "Img")]        
        public string ImgPath { get; set; }

    }

}
