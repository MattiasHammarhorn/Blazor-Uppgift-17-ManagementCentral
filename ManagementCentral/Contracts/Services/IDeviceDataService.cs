using ManagementCentral.Models;

namespace ManagementCentral.Contracts.Services
{
    public interface IDeviceDataService
    {
        Task<IEnumerable<Device>> GetDevices();
        Task<int> GetDevicesCount();
        Task<int> GetActiveDevicesCount();
        Task<Device> GetDeviceById(Guid deviceId);
        Task<Device> GetLastEditedDevice();
        Task<Device> AddDevice(Device device);
        Task<Device> UpdateDevice(Device device);
        Task DeleteDevice(Guid deviceId);
    }
}
