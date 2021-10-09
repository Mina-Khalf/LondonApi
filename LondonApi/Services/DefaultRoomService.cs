using AutoMapper;
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
        private readonly IMapper _mapper;
        public DefaultRoomService(HotelApiDbContext context ,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Room> GetRoomByIdAsync(Guid roomId)
        {
            var room = await _context.Rooms.SingleOrDefaultAsync(r => r.Id == roomId);

            if (room == null)
                return null;
            return _mapper.Map<Room>(room);
        }
    }
}
