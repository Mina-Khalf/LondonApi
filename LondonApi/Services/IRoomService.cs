using LondonApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoomByIdAsync(Guid roomId);
    }
}
