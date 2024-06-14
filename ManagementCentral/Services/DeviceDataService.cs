using ManagementCentral.Contracts.Repositories;
using ManagementCentral.Contracts.Services;
using ManagementCentral.Models;

namespace ManagementCentral.Services
{
    public class DeviceDataService : IDeviceDataService
    {
        private readonly IDeviceRepository _repository;

        public DeviceDataService(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Device>> GetDevices()
        {
            return await _repository.GetDevices();
        }

        public async Task<int> GetDevicesCount()
        {
            return await _repository.GetDevicesCount();
        }

        public async Task<int> GetActiveDevicesCount()
        {
            return await _repository.GetActiveDevicesCount();
        }

        public async Task<Device> GetDeviceById(Guid deviceId)
        {
            return await _repository.GetDeviceById(deviceId);
        }

        public async Task<Device> GetLastEditedDevice()
        {
            return await _repository.GetLastEditedDevice();
        }

        public async Task<Device> AddDevice(Device device)
        {
            return await _repository.AddDevice(device);
        }

        public async Task<Device> UpdateDevice(Device device)
        {
            return await _repository.UpdateDevice(device);
        }

        public async Task DeleteDevice(Guid deviceId)
        {
            await _repository.DeleteDevice(deviceId);
        }
    }
}
