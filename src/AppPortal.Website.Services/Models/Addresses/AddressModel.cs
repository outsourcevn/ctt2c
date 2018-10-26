namespace AppPortal.Website.Services.Models.Addresses
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProvinceType { get; set; }
        public string LatLong { get; set; }
        public int? ProvinceId { get; set; }
    }
}
