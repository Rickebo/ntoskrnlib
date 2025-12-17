#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _CONFIGURATION_COMPONENT_DATA
    {
        [FieldOffset(0)]
        public IntPtr Parent;
        [FieldOffset(8)]
        public IntPtr Child;
        [FieldOffset(16)]
        public IntPtr Sibling;
        [FieldOffset(24)]
        public _CONFIGURATION_COMPONENT ComponentEntry;
        [FieldOffset(64)]
        public IntPtr ConfigurationData;
    }
}