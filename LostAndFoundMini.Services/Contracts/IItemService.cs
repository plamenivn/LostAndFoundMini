using LostAndFoundMini.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundMini.Services.Contracts
{
    public interface IItemService
    {
        IEnumerable<Item> GetAll();
        Item? GetById(int id);
        void Create(Item item);
    }
}
