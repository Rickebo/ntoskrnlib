#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PCW_MASK_INFORMATION
    {
        [FieldOffset(0)]
        public ulong CounterMask;
        [FieldOffset(8)]
        public IntPtr InstanceMask;
        [FieldOffset(16)]
        public uint InstanceId;
        [FieldOffset(20)]
        public byte CollectMultiple;
        [FieldOffset(24)]
        public IntPtr Buffer;
        [FieldOffset(32)]
        public IntPtr CancelEvent;
    }
}