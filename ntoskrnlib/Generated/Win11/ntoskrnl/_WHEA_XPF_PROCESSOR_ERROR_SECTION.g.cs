#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 65)]
    public partial struct _WHEA_XPF_PROCESSOR_ERROR_SECTION
    {
        [FieldOffset(0)]
        public _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS ValidBits;
        [FieldOffset(8)]
        public ulong LocalAPICId;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] CpuId;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] VariableInfo;
    }
}