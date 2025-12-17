#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _XPF_RECOVERY_INFO
    {
        [FieldOffset(0)]
        public _unnamed_tag_ FailureReason;
        [FieldOffset(4)]
        public _unnamed_tag_ Action;
        [FieldOffset(8)]
        public byte ActionRequired;
        [FieldOffset(9)]
        public byte RecoverySucceeded;
        [FieldOffset(10)]
        public byte RecoveryKernel;
        [FieldOffset(11)]
        public byte Reserved;
        [FieldOffset(12)]
        public ushort Reserved2;
        [FieldOffset(14)]
        public ushort Reserved3;
        [FieldOffset(16)]
        public uint Reserved4;
    }
}