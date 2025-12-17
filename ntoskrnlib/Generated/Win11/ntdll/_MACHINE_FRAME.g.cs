#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MACHINE_FRAME
    {
        [FieldOffset(0)]
        public ulong Rip;
        [FieldOffset(8)]
        public ushort SegCs;
        [FieldOffset(10)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Fill1;
        [FieldOffset(16)]
        public uint EFlags;
        [FieldOffset(20)]
        public uint Fill2;
        [FieldOffset(24)]
        public ulong Rsp;
        [FieldOffset(32)]
        public ushort SegSs;
        [FieldOffset(34)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Fill3;
    }
}