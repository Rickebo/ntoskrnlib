#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _BLOB_COUNTERS
    {
        [FieldOffset(0)]
        public uint CreatedObjects;
        [FieldOffset(4)]
        public uint DeletedObjects;
    }
}