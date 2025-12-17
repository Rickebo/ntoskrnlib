#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KDEVICE_QUEUE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DeviceListEntry;
        [FieldOffset(16)]
        public uint SortKey;
        [FieldOffset(20)]
        public byte Inserted;
    }
}