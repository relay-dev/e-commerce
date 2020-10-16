using System;

namespace ECommerce
{
    public struct Address : IEquatable<Address>
    {
        public long AddressId { get; set; }
        public string AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string PostalCode { get; set; }
        public string PostalCodeLastFour { get; set; }
        public string County { get; set; }
        public string CountryCode { get; set; }
        public bool IsActive { get; set; }
        public bool? IsValid { get; set; }
        public bool IsPhysical { get; set; }
        public bool IsPrimaryBilling { get; set; }
        public bool IsPrimaryShipping { get; set; }

        public string DisplayLine1
        {
            get
            {
                if (string.IsNullOrEmpty(Line1))
                {
                    return Line1;
                }

                return $"{Line1} {Line2}";
            }
        }

        public string DisplayLine2
        {
            get
            {
                if (string.IsNullOrEmpty(City))
                {
                    return $"{StateProv} {PostalCode}";
                }

                return $"{City}, {StateProv} {PostalCode}";
            }
        }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(Address other)
        {
            return AddressId == other.AddressId && AddressType == other.AddressType && Line1 == other.Line1 && Line2 == other.Line2 && Line3 == other.Line3 && City == other.City && StateProv == other.StateProv && PostalCode == other.PostalCode && PostalCodeLastFour == other.PostalCodeLastFour && County == other.County && CountryCode == other.CountryCode && IsActive == other.IsActive && IsValid == other.IsValid && IsPhysical == other.IsPhysical && IsPrimaryBilling == other.IsPrimaryBilling && IsPrimaryShipping == other.IsPrimaryShipping;
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is Address other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(AddressId);
            hashCode.Add(AddressType);
            hashCode.Add(Line1);
            hashCode.Add(Line2);
            hashCode.Add(Line3);
            hashCode.Add(City);
            hashCode.Add(StateProv);
            hashCode.Add(PostalCode);
            hashCode.Add(PostalCodeLastFour);
            hashCode.Add(County);
            hashCode.Add(CountryCode);
            hashCode.Add(IsActive);
            hashCode.Add(IsValid);
            hashCode.Add(IsPhysical);
            hashCode.Add(IsPrimaryBilling);
            hashCode.Add(IsPrimaryShipping);
            return hashCode.ToHashCode();
        }
    }
}
