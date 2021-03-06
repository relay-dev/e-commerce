﻿using System;

namespace ECommerce
{
    public struct Note : IEquatable<Note>
    {
        public long NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteValue { get; set; }
        public bool IsSuppressed { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals(Note other)
        {
            return NoteId == other.NoteId && NoteType == other.NoteType && NoteValue == other.NoteValue && IsSuppressed == other.IsSuppressed;
        }

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object obj)
        {
            return obj is Note other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(NoteId, NoteType, NoteValue, IsSuppressed);
        }
    }
}
