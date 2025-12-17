#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS
    {
        [FieldOffset(0)]
        public ulong LocalAPICId;
        [FieldOffset(0)]
        public ulong CpuId;
        [FieldOffset(0)]
        public ulong ProcInfoCount;
        [FieldOffset(0)]
        public ulong ContextInfoCount;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong ValidBits;
    }
}