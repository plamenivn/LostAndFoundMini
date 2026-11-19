using LostAndFoundMini.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundMini.Services.DTOs.Items
{
    public class ItemListDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
