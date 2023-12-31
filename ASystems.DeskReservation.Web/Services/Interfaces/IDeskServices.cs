﻿using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IDeskServices
{
    Task<List<Desk>> GetAll();
    Task<Desk> GetAsync(Guid id);
    Task<Desk> Create(Desk desk);
    Task<Desk> Edit(Desk desk);
    Task<Desk> Delete(Guid id);
    Task<Desk> Details(Guid id);
    Task<List<Desk>> GetFreeDesks(DateTime StartDate, DateTime EndDate);
}
