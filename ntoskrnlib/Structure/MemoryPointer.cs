using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Structure
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MemoryPointer : IValidableMemoryPointer, IEquatable<MemoryPointer>, IComparable<MemoryPointer>
    {
        [FieldOffset(0x0)]
        public ulong Value;

        public bool IsValid() => Value != 0 && Value != ulong.MaxValue;

        // Addition/subtraction with unsigned offsets
        public static MemoryPointer operator +(MemoryPointer p, ulong offset) => new MemoryPointer { Value = unchecked(p.Value + offset) };
        public static MemoryPointer operator -(MemoryPointer p, ulong offset) => new MemoryPointer { Value = unchecked(p.Value - offset) };

        // Addition/subtraction with signed offsets
        public static MemoryPointer operator +(MemoryPointer p, long offset)
            => offset >= 0
                ? new MemoryPointer { Value = unchecked(p.Value + (ulong)offset) }
                : new MemoryPointer { Value = unchecked(p.Value - (ulong)(-offset)) };

        public static MemoryPointer operator -(MemoryPointer p, long offset)
            => p + (-offset);

        public static MemoryPointer operator +(MemoryPointer p, int offset) => p + (long)offset;
        public static MemoryPointer operator -(MemoryPointer p, int offset) => p - (long)offset;

        // Commutative addition
        public static MemoryPointer operator +(ulong offset, MemoryPointer p) => p + offset;
        public static MemoryPointer operator +(long offset, MemoryPointer p) => p + offset;
        public static MemoryPointer operator +(int offset, MemoryPointer p) => p + offset;

        // Increment/decrement
        public static MemoryPointer operator ++(MemoryPointer p)
        {
            p.Value = unchecked(p.Value + 1);
            return p;
        }
        public static MemoryPointer operator --(MemoryPointer p)
        {
            p.Value = unchecked(p.Value - 1);
            return p;
        }

        // Difference between two pointers (signed delta)
        public static long operator -(MemoryPointer a, MemoryPointer b) => unchecked((long)(a.Value - b.Value));

        public static implicit operator ulong(MemoryPointer p) => p.Value;
        public static explicit operator MemoryPointer(ulong v) => new MemoryPointer { Value = v };

        public override string ToString() => $"0x{Value:X}";

        public bool Equals(MemoryPointer other) => Value == other.Value;
        public override bool Equals(object obj) => obj is MemoryPointer mp && Equals(mp);
        public override int GetHashCode() => Value.GetHashCode();

        // Comparisons
        public static bool operator ==(MemoryPointer a, MemoryPointer b) => a.Value == b.Value;
        public static bool operator !=(MemoryPointer a, MemoryPointer b) => a.Value != b.Value;
        public static bool operator <(MemoryPointer a, MemoryPointer b) => a.Value < b.Value;
        public static bool operator >(MemoryPointer a, MemoryPointer b) => a.Value > b.Value;
        public static bool operator <=(MemoryPointer a, MemoryPointer b) => a.Value <= b.Value;
        public static bool operator >=(MemoryPointer a, MemoryPointer b) => a.Value >= b.Value;

        public int CompareTo(MemoryPointer other) => Value.CompareTo(other.Value);

        // Helper methods
        public MemoryPointer Add(ulong offset) => this + offset;
        public MemoryPointer Add(long offset) => this + offset;
        public MemoryPointer Add(int offset) => this + offset;
        public MemoryPointer Subtract(ulong offset) => this - offset;
        public MemoryPointer Subtract(long offset) => this - offset;
        public MemoryPointer Subtract(int offset) => this - offset;
        public ulong Difference(MemoryPointer other) => unchecked(Value - other.Value);
    }
}
