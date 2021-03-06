﻿using Spg.TicketShop.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Spg.TicketShop.Services.Interfaces
{
    public interface IShowService
    {
        Task<IEnumerable<Shows>> GetAllAsync();

        Task<IEnumerable<Shows>> GetAllByEventAsync(Guid eventId);

        Task<Shows> GetSingleOrDefaultAsync(Guid id);

        Task<Shows> CreateAsync(Shows newModel);

        Task<Shows> EditAsync(Guid id, Shows newModel);

        Task<Shows> DeleteAsync(Guid? id);
    }
}
