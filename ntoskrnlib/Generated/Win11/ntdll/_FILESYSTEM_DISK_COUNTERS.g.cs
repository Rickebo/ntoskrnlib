#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _FILESYSTEM_DISK_COUNTERS
    {
        [FieldOffset(0)]
        public ulong FsBytesRead;
        [FieldOffset(8)]
        public ulong FsBytesWritten;
    }
}