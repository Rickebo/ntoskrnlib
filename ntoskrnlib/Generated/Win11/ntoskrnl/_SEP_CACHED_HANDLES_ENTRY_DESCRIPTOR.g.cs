#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint DescriptorType;
        [FieldOffset(8)]
        public IntPtr PackageSid;
        [FieldOffset(8)]
        public _UNICODE_STRING IsolationPrefix;
    }
}