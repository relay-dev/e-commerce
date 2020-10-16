using System;

namespace ECommerce
{
    public struct PhoneNumber : IEquatable<PhoneNumber>
    {
        public long PhoneNumberId { get; set; }
        public string PhoneNumberType { get; set; }
        public string PhoneNumberValue { get; set; }
        public string PhoneNumberNumeric { get; set; }
        public string CountryCode { get; set; }
        public bool IsActive { get; set; }
        public bool? IsValid { get; set; }
        public bool IsOnDncList { get; set; }
        public bool IsPrimary { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(PhoneNumber other)
        {
            return PhoneNumberId == other.PhoneNumberId && PhoneNumberType == other.PhoneNumberType && PhoneNumberValue == other.PhoneNumberValue && PhoneNumberNumeric == other.PhoneNumberNumeric && CountryCode == other.CountryCode && IsActive == other.IsActive && IsValid == other.IsValid && IsOnDncList == other.IsOnDncList && IsPrimary == other.IsPrimary;
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is PhoneNumber other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(PhoneNumberId);
            hashCode.Add(PhoneNumberType);
            hashCode.Add(PhoneNumberValue);
            hashCode.Add(PhoneNumberNumeric);
            hashCode.Add(CountryCode);
            hashCode.Add(IsActive);
            hashCode.Add(IsValid);
            hashCode.Add(IsOnDncList);
            hashCode.Add(IsPrimary);
            return hashCode.ToHashCode();
        }
    }
}
