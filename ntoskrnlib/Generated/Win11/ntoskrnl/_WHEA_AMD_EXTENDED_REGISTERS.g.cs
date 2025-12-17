#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _WHEA_AMD_EXTENDED_REGISTERS
    {
        [FieldOffset(0)]
        public ulong IPID;
        [FieldOffset(8)]
        public ulong SYND;
        [FieldOffset(16)]
        public ulong CONFIG;
        [FieldOffset(24)]
        public ulong DESTAT;
        [FieldOffset(32)]
        public ulong DEADDR;
        [FieldOffset(40)]
        public ulong MISC1;
        [FieldOffset(48)]
        public ulong MISC2;
        [FieldOffset(56)]
        public ulong MISC3;
        [FieldOffset(64)]
        public ulong MISC4;
        [FieldOffset(72)]
        public ulong RasCap;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public ulong[] Reserved;
    }
}