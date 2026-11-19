using LostAndFoundMini.Services.DTOs.Items;

namespace LostAndFoundMini.Web.ViewModels.Items
{
    public class ItemsIndexViewModel
    {
        public List<ItemListDto> Items { get; set; } = new();
    }
}
