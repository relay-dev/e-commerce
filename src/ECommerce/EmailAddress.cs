using System;

namespace ECommerce
{
    public struct EmailAddress : IEquatable<EmailAddress>
    {
        public long EmailAddressId { get; set; }
        public string EmailAddressType { get; set; }
        public string EmailAddressValue { get; set; }
        public bool IsActive { get; set; }
        public bool? IsValid { get; set; }
        public bool IsPrimary { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(EmailAddress other)
        {
            return EmailAddressId == other.EmailAddressId && EmailAddressType == other.EmailAddressType && EmailAddressValue == other.EmailAddressValue && IsActive == other.IsActive && IsValid == other.IsValid && IsPrimary == other.IsPrimary;
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is EmailAddress other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(EmailAddressId, EmailAddressType, EmailAddressValue, IsActive, IsValid, IsPrimary);
        }
    }
}
