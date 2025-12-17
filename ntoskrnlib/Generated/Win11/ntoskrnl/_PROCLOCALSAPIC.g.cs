#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 17)]
    public partial struct _PROCLOCALSAPIC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public byte ACPIProcessorID;
        [FieldOffset(3)]
        public byte APICID;
        [FieldOffset(4)]
        public byte APICEID;
        [FieldOffset(5)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint ACPIProcessorUIDInteger;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public sbyte[] ACPIProcessorUIDString;
    }
}