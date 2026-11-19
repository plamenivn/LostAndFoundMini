using LostAndFoundMini.Data;
using LostAndFoundMini.Data.Entities;
using LostAndFoundMini.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundMini.Services
{
    public class ItemService : IItemService
    {
        private readonly ItemDbContext _context;

        public ItemService(ItemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            return _context.Items.ToList();
        }

        public Item? GetById(int id)
        {
            return _context.Items.FirstOrDefault(i => i.Id == id);
        }

        public void Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }
    }
}
