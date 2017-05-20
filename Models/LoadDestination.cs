using System;

namespace Dispatcher.Models
{
    public class LoadDestination : BaseEntity
    {
        public int addressId;

        public Address address;

        public DateTime deliverBy;

        public string description;

        
    }
}