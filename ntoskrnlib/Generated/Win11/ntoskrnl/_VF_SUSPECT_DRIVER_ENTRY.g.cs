#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _VF_SUSPECT_DRIVER_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public uint Loads;
        [FieldOffset(20)]
        public uint Unloads;
        [FieldOffset(24)]
        public _UNICODE_STRING FullName;
        [FieldOffset(40)]
        public _UNICODE_STRING BaseName;
    }
}