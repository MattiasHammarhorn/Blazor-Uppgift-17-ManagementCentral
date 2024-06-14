﻿using ManagementCentral.Contracts.Repositories;
using ManagementCentral.Data;
using ManagementCentral.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ManagementCentral.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly InMemoryDbContext _context;

        public DeviceRepository(IDbContextFactory<InMemoryDbContext> DbFactory)
        {
            _context = DbFactory.CreateDbContext();
        }

        public async Task<Device> AddDevice(Device device)
        {
            var addedEntity = await _context.Devices.AddAsync(device);
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<IEnumerable<Device>> GetActiveDevices()
        {
            return await _context.Devices.Where(d => d.isActive == true).ToListAsync();
        }

        public async Task<IEnumerable<Device>> GetDevices()
        {
            return await _context.Devices.ToListAsync();
        }

        public async Task<int> GetDevicesCount()
        {
            return await _context.Devices.CountAsync();
        }

        public async Task<Device> GetLastEditedDevice()
        {
            return await _context.Devices.OrderBy(d => d.LastEditedOn).SingleOrDefaultAsync();
        }
    }
}