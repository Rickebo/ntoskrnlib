#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _FILE_BASIC_INFORMATION
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER CreationTime;
        [FieldOffset(8)]
        public _LARGE_INTEGER LastAccessTime;
        [FieldOffset(16)]
        public _LARGE_INTEGER LastWriteTime;
        [FieldOffset(24)]
        public _LARGE_INTEGER ChangeTime;
        [FieldOffset(32)]
        public uint FileAttributes;
    }
}