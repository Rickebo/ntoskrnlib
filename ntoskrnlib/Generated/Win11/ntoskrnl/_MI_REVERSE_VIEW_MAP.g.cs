#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_REVERSE_VIEW_MAP
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ViewLinks;
        [FieldOffset(16)]
        public IntPtr SystemCacheVa;
        [FieldOffset(16)]
        public IntPtr VadsProcess;
        [FieldOffset(16)]
        public ulong Type;
        [FieldOffset(24)]
        public IntPtr Subsection;
        [FieldOffset(24)]
        public ulong SubsectionType;
        [FieldOffset(32)]
        public _MI_REVERSE_MAP_VIEW_ATTRIBUTES Attributes;
    }
}