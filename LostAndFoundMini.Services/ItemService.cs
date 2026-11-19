using LostAndFoundMini.Data;
using LostAndFoundMini.Data.Entities;
using LostAndFoundMini.Services.Contracts;
using LostAndFoundMini.Services.DTOs.Items;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ItemListDto>> GetAllAsync()
        {
            return await _context.Items
                .Select(i => new ItemListDto
                {
                    Id = i.Id,
                    Title = i.Title,
                    Type = i.Type,
                    Location = i.Location,
                    Date = i.Date
                })
                .ToListAsync();
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
