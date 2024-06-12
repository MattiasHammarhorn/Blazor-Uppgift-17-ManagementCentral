namespace ManagementCentral.Models
{
    public class Device
    {
        //  namn, id (GUID), aktuell status (online/offline) samt senaste data som skickats från maskinen
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string LastData { get; set; }
        public bool isActive { get; set; }
    }
}
