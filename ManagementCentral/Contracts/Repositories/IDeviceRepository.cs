using ManagementCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementCentral.Contracts.Repositories
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetDevices();
        Task<int> GetDevicesCount();
        Task<IEnumerable<Device>> GetActiveDevices();
        Task<Device> GetDeviceById(Guid deviceId);
        Task<Device> GetLastEditedDevice();
        Task<Device> AddDevice(Device device);
        Task<Device> UpdateDevice(Device device);
    }
}
