#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _IO_APIC_DATA
    {
        [FieldOffset(0)]
        public ulong PhysicalAddress;
        [FieldOffset(8)]
        public uint Identifier;
        [FieldOffset(16)]
        public IntPtr BaseAddress;
        [FieldOffset(24)]
        public byte Version;
        [FieldOffset(25)]
        public byte PinCount;
        [FieldOffset(26)]
        public byte Initialized;
        [FieldOffset(27)]
        public byte InitializedFirstLocalUnit;
        [FieldOffset(28)]
        public uint GsiBase;
        [FieldOffset(32)]
        public uint CmciRegister;
        [FieldOffset(36)]
        public uint DeferredErrorRegister;
        [FieldOffset(40)]
        public byte IoUnitMissing;
    }
}