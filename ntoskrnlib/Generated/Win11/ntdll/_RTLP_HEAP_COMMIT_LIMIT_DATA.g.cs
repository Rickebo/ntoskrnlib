#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTLP_HEAP_COMMIT_LIMIT_DATA
    {
        [FieldOffset(0)]
        public ulong CommitLimitBytes;
        [FieldOffset(8)]
        public ulong CommitLimitFailureCode;
    }
}