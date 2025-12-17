#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _LDR_HOT_PATCH_DATA
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr PatchLoadLibrary;
        [FieldOffset(16)]
        public IntPtr PatchGetProcAddress;
    }
}