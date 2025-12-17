#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PLATFORM_INTERRUPT
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(4)]
        public byte InterruptType;
        [FieldOffset(5)]
        public byte APICID;
        [FieldOffset(6)]
        public byte ACPIEID;
        [FieldOffset(7)]
        public byte IOSAPICVector;
        [FieldOffset(8)]
        public uint GlobalVector;
        [FieldOffset(12)]
        public uint Reserved;
    }
}