using System.ComponentModel.DataAnnotations;
namespace LostAndFoundMini.Web.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заглавието е задължително!")]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Видът е задължителен!")]
        [Display(Name = "Вид (Изгубено/Намерено)")]
        public string Type { get; set; } = string.Empty; 
        [Required(ErrorMessage = "Мястото е задължително!")]
        [Display(Name = "Място")]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Датата е задължителна!")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}
