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

        public async Task<IEnumerable<Device>> GetActiveDevices()
        {
            return await _repository.GetActiveDevices();
        }

        public async Task<Device> GetLastEditedDevice()
        {
            return await _repository.GetLastEditedDevice();
        }

        public async Task<Device> AddDevice(Device device)
        {
            return await _repository.AddDevice(device);
        }
    }
}
