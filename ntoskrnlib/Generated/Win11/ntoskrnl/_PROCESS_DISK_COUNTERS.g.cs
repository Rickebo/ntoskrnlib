#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PROCESS_DISK_COUNTERS
    {
        [FieldOffset(0)]
        public ulong BytesRead;
        [FieldOffset(8)]
        public ulong BytesWritten;
        [FieldOffset(16)]
        public ulong ReadOperationCount;
        [FieldOffset(24)]
        public ulong WriteOperationCount;
        [FieldOffset(32)]
        public ulong FlushOperationCount;
    }
}