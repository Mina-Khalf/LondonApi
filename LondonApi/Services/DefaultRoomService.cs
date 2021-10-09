using LondonApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Services
{
    public class DefaultRoomService : IRoomService
    {
        private readonly HotelApiDbContext _context;
        public DefaultRoomService(HotelApiDbContext context)
        {
            _context = context;
        }
        public async Task<Room> GetRoomByIdAsync(Guid roomId)
        {
            var room = await _context.Rooms.SingleOrDefaultAsync(r => r.Id == roomId);

            if (room == null)
                return null;
            return new Room()
            {
                Href =null,// Url.Link(nameof(GetRoomById), new { roomId = room.Id }),
                Name = room.Name,
                Rate = room.Rate / 100.0m
            };
        }
    }
}
