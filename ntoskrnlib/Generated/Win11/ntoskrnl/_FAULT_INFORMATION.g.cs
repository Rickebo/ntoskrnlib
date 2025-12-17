#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _FAULT_INFORMATION
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public byte IsStage1;
        [FieldOffset(8)]
        public _FAULT_INFORMATION_ARM64 Arm64;
        [FieldOffset(8)]
        public _FAULT_INFORMATION_X64 X64;
    }
}