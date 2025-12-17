#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _FILE_NETWORK_OPEN_INFORMATION
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
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(40)]
        public _LARGE_INTEGER EndOfFile;
        [FieldOffset(48)]
        public uint FileAttributes;
    }
}