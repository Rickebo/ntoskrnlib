#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KDPC_DATA
    {
        [FieldOffset(0)]
        public _KDPC_LIST DpcList;
        [FieldOffset(16)]
        public ulong DpcLock;
        [FieldOffset(24)]
        public int DpcQueueDepth;
        [FieldOffset(28)]
        public uint DpcCount;
        [FieldOffset(32)]
        public IntPtr ActiveDpc;
        [FieldOffset(40)]
        public uint LongDpcPresent;
        [FieldOffset(44)]
        public uint Padding;
    }
}