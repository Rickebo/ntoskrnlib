#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _LOADER_BOOT_APPLICATION_SVN_INFORMATION
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER BootStlCreationTime;
        [FieldOffset(8)]
        public uint HiberrsmMinSvn;
    }
}