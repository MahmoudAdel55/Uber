using Domain_Layer.Common;
using Domain_Layer.Entities.Drivers;


namespace Domain_Layer.Entities.Passengers
{
    public class Passenger : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }

        // Navigational Property
        public Driver Driver { get; set; } = default!;

    }
}
