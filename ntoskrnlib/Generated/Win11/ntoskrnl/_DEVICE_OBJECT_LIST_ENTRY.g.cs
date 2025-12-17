#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DEVICE_OBJECT_LIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr DeviceObject;
        [FieldOffset(8)]
        public uint RelationLevel;
        [FieldOffset(12)]
        public uint Ordinal;
        [FieldOffset(16)]
        public uint Flags;
    }
}