using LostAndFoundMini.Data.Entities;
using LostAndFoundMini.Services.DTOs.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundMini.Services.Contracts
{
    public interface IItemService
    {
        Task<List<ItemListDto>> GetAllAsync();
        Item? GetById(int id);
        void Create(Item item);
    }
}
