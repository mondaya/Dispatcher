using System;

namespace Dispatcher.Models
{
    public class LoadSource : BaseEntity
    {
        public int addressId;
        public Address address;

        public DateTime readyBy;

        public string description;

    }
}