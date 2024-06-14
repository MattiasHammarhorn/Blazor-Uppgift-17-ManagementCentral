using ManagementCentral.Models;

namespace ManagementCentral.Contracts.Repositories
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetDevices();
        Task<int> GetDevicesCount();
        Task<IEnumerable<Device>> GetActiveDevices();
        Task<Device> GetLastEditedDevice();
        Task<Device> AddDevice(Device device);
    }
}
