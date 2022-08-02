using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(20)]
        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}