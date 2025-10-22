using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Structure
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MemoryPointer : IValidableMemoryPointer, IEquatable<MemoryPointer>
    {
        [FieldOffset(0x0)]
        public ulong Value;

        public bool IsValid() => Value != 0 && Value != ulong.MaxValue;

        public static MemoryPointer operator +(MemoryPointer p, ulong offset) => new MemoryPointer { Value = p.Value + offset };
        public static MemoryPointer operator -(MemoryPointer p, ulong offset) => new MemoryPointer { Value = p.Value - offset };

        public static implicit operator ulong(MemoryPointer p) => p.Value;
        public static explicit operator MemoryPointer(ulong v) => new MemoryPointer { Value = v };

        public override string ToString() => $"0x{Value:X}";

        public bool Equals(MemoryPointer other) => Value == other.Value;
        public override bool Equals(object obj) => obj is MemoryPointer mp && Equals(mp);
        public override int GetHashCode() => Value.GetHashCode();
    }
}
