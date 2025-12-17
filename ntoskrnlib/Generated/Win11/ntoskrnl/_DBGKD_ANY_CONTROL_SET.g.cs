#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _DBGKD_ANY_CONTROL_SET
    {
        [FieldOffset(0)]
        public _X86_DBGKD_CONTROL_SET X86ControlSet;
        [FieldOffset(0)]
        public uint AlphaControlSet;
        [FieldOffset(0)]
        public _IA64_DBGKD_CONTROL_SET IA64ControlSet;
        [FieldOffset(0)]
        public _AMD64_DBGKD_CONTROL_SET Amd64ControlSet;
        [FieldOffset(0)]
        public _ARM_DBGKD_CONTROL_SET ArmControlSet;
        [FieldOffset(0)]
        public _ARM64_DBGKD_CONTROL_SET Arm64ControlSet;
        [FieldOffset(0)]
        public _ARMCE_DBGKD_CONTROL_SET ArmCeControlSet;
        [FieldOffset(0)]
        public _PPC_DBGKD_CONTROL_SET PpcControlSet;
    }
}