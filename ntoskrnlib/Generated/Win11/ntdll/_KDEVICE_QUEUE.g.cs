#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _KDEVICE_QUEUE
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public _LIST_ENTRY DeviceListHead;
        [FieldOffset(24)]
        public ulong Lock;
        [FieldOffset(32)]
        public byte Busy;
        [FieldOffset(32)]
        public long Reserved;
        [FieldOffset(32)]
        public long Hint;
    }
}