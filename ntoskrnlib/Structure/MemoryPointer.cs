using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Structure
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MemoryPointer : IValidableMemoryPointer, IEquatable<MemoryPointer>, IComparable<MemoryPointer>
    {
        [FieldOffset(0x0)]
        public ulong Value;

        // Constructors for common value types
        public MemoryPointer(ulong value) { Value = value; }
        public MemoryPointer(long value) { Value = unchecked((ulong)value); }
        public MemoryPointer(IntPtr value) { Value = unchecked((ulong)value.ToInt64()); }
        public MemoryPointer(UIntPtr value) { Value = value.ToUInt64(); }

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
        public static explicit operator MemoryPointer(ulong v) => new MemoryPointer(v);
        public static explicit operator MemoryPointer(long v) => new MemoryPointer(v);
        public static explicit operator MemoryPointer(IntPtr v) => new MemoryPointer(v);
        public static explicit operator MemoryPointer(UIntPtr v) => new MemoryPointer(v);

        public static explicit operator IntPtr(MemoryPointer p) => new IntPtr(unchecked((long)p.Value));
        public static explicit operator UIntPtr(MemoryPointer p) => new UIntPtr(p.Value);

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

        // Common named values
        public static MemoryPointer Zero => new MemoryPointer(0UL);
        public bool IsZero => Value == 0UL;
    }
}
