#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EXT_DELETE_PARAMETERS
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public IntPtr DeleteCallback;
        [FieldOffset(16)]
        public IntPtr DeleteContext;
    }
}