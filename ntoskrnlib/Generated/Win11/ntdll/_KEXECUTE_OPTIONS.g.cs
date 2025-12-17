#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KEXECUTE_OPTIONS
    {
        [FieldOffset(0)]
        public byte ExecuteDisable;
        [FieldOffset(0)]
        public byte ExecuteEnable;
        [FieldOffset(0)]
        public byte DisableThunkEmulation;
        [FieldOffset(0)]
        public byte Permanent;
        [FieldOffset(0)]
        public byte ExecuteDispatchEnable;
        [FieldOffset(0)]
        public byte ImageDispatchEnable;
        [FieldOffset(0)]
        public byte DisableExceptionChainValidation;
        [FieldOffset(0)]
        public byte Spare;
        [FieldOffset(0)]
        public byte ExecuteOptions;
        [FieldOffset(0)]
        public byte ExecuteOptionsNV;
    }
}