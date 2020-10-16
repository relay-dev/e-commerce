using System;

namespace ECommerce
{
    public struct CustomerIdentification : IEquatable<CustomerIdentification>
    {
        public long CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(CustomerIdentification other)
        {
            return CustomerId == other.CustomerId && CustomerNumber == other.CustomerNumber && Username == other.Username && FirstName == other.FirstName && LastName == other.LastName;
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is CustomerIdentification other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerId, CustomerNumber, Username, FirstName, LastName);
        }
    }
}
