namespace AppPortal.AdminSite.Services.Models
{
    public class ListItemModel<Tkey, TField>
    {
        public Tkey Id { get; set; }
        public string Name { get; set; }
        public TField Field { get; set; }
    }
}
