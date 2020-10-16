using System;
using System.Collections.Generic;

namespace ECommerce
{
    public struct Customer : IEquatable<Customer>
    {
        public long CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerStatus { get; set; }
        public string CustomerType { get; set; }
        public string BrandCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive { get; set; }
        public string BusinessName { get; set; }
        public string ExternalReferenceId { get; set; }
        public string Username { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }
        public List<Note> Notes { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(Customer other)
        {
            return CustomerId == other.CustomerId && CustomerStatus == other.CustomerStatus && CustomerType == other.CustomerType && BrandCode == other.BrandCode && FirstName == other.FirstName && LastName == other.LastName && CustomerNumber == other.CustomerNumber && JoinDate.Equals(other.JoinDate) && IsActive == other.IsActive && BusinessName == other.BusinessName && ExternalReferenceId == other.ExternalReferenceId && Username == other.Username && Equals(Addresses, other.Addresses) && Equals(Attributes, other.Attributes) && Equals(EmailAddresses, other.EmailAddresses) && Equals(PhoneNumbers, other.PhoneNumbers);
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is Customer other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(CustomerId);
            hashCode.Add(CustomerStatus);
            hashCode.Add(CustomerType);
            hashCode.Add(BrandCode);
            hashCode.Add(FirstName);
            hashCode.Add(LastName);
            hashCode.Add(CustomerNumber);
            hashCode.Add(JoinDate);
            hashCode.Add(IsActive);
            hashCode.Add(BusinessName);
            hashCode.Add(ExternalReferenceId);
            hashCode.Add(Username);
            hashCode.Add(Addresses);
            hashCode.Add(Attributes);
            hashCode.Add(EmailAddresses);
            hashCode.Add(PhoneNumbers);
            return hashCode.ToHashCode();
        }
    }
}
