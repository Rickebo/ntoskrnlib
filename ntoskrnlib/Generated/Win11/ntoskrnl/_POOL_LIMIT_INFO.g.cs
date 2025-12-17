#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _POOL_LIMIT_INFO
    {
        [FieldOffset(0)]
        public ulong HardMemoryLimit;
        [FieldOffset(8)]
        public ulong NotificationLimit;
        [FieldOffset(16)]
        public ulong MemoryIssued;
    }
}