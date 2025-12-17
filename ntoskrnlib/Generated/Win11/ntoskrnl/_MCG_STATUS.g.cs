#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCG_STATUS
    {
        [FieldOffset(0)]
        public uint RestartIpValid;
        [FieldOffset(0)]
        public uint ErrorIpValid;
        [FieldOffset(0)]
        public uint MachineCheckInProgress;
        [FieldOffset(0)]
        public uint LocalMceValid;
        [FieldOffset(0)]
        public uint Reserved1;
        [FieldOffset(4)]
        public uint Reserved2;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}