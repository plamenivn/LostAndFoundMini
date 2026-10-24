using LostAndFoundMini.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundMini.Data.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Заглавието е задължително!")]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Видът е задължителен!")]
        public ItemType Type { get; set; }

        [Required(ErrorMessage = "Мястото е задължително!")]
        [MaxLength(150)]
        public string Location { get; set; } = string.Empty;

        [Required(ErrorMessage = "Датата е задължителна!")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        public string? Description { get; set; }
    }
}
