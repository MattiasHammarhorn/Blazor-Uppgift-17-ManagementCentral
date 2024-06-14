using ManagementCentral.Models;

namespace ManagementCentral.Contracts.Services
{
    public interface IDeviceDataService
    {
        Task<IEnumerable<Device>> GetDevices();
        Task<int> GetDevicesCount();
        Task<IEnumerable<Device>> GetActiveDevices();
        Task<Device> GetDeviceById(Guid deviceId);
        Task<Device> GetLastEditedDevice();
        Task<Device> AddDevice(Device device);
        Task<Device> UpdateDevice(Device device);
        Task DeleteDevice(Guid deviceId);
    }
}
