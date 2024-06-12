using ManagementCentral.Models;

namespace ManagementCentral.Services
{
    public class DeviceDataService
    {
        List<Device> devices = new List<Device>
        {
            new Device
            {
                Id = Guid.NewGuid(),
                Location = "Jordbro",
                isActive = true,
                Type = "Bulldozer",
                LastEditedOn = new DateTime(2024,5,29),
                LastData = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            },
            new Device
            {
                Id = Guid.NewGuid(),
                Location = "Farsta",
                isActive = true,
                Type = "Lift",
                LastEditedOn = new DateTime(2024,6,3),
                LastData = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
            },
            new Device
            {
                Id = Guid.NewGuid(),
                Location = "Länna",
                isActive = false,
                Type = "Excavator",
                LastEditedOn = new DateTime(2024,6,12),
                LastData = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
            }
        };

        public IEnumerable<Device> GetDevices()
        {
            return devices.ToList();
        }

        public int GetDevicesCount()
        {
            return devices.Count();
        }

        public IEnumerable<Device> GetDevicesOnline()
        {
            return devices.Where(d => d.isActive).ToList();
        }

        public Device GetLastEditedDevice()
        {
            return devices.OrderBy(d => d.LastEditedOn).SingleOrDefault();
        }
    }
}
