using Domain_Layer.Common;
using Domain_Layer.Entities.Passengers;
using System;

namespace Domain_Layer.Entities.Drivers
{
    public class Driver : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string PictureUrl { get; set; } = default!;
        public decimal Price { get; set; }

        // Navigational Property
        public Passenger Passenger { get; set; } = default!;
        public int PassengerId { get; set; } = default!;
    }
}
