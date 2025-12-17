#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _KPRCB_BPB_STATE
    {
        [FieldOffset(0)]
        public ushort CpuIdle;
        [FieldOffset(0)]
        public ushort FlushRsbOnTrap;
        [FieldOffset(0)]
        public ushort IbpbOnReturn;
        [FieldOffset(0)]
        public ushort IbpbOnTrap;
        [FieldOffset(0)]
        public ushort IbpbOnRetpolineExit;
        [FieldOffset(0)]
        public ushort FlushRsbOnReturn;
        [FieldOffset(0)]
        public ushort FlushRsbOnRetpolineExit;
        [FieldOffset(0)]
        public ushort FlushBhbOnTrap;
        [FieldOffset(0)]
        public ushort DivideOnReturn;
        [FieldOffset(0)]
        public ushort Reserved1;
        [FieldOffset(0)]
        public ushort Spare;
        [FieldOffset(0)]
        public ushort AllFlags;
    }
}