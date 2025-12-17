#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROCESS_NETWORK_COUNTERS
    {
        [FieldOffset(0)]
        public ulong BytesIn;
        [FieldOffset(8)]
        public ulong BytesOut;
    }
}