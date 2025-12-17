#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IOSAPIC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public byte IOSAPICID;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public uint SystemVectorBase;
        [FieldOffset(8)]
        public ulong IOSAPICAddress;
    }
}