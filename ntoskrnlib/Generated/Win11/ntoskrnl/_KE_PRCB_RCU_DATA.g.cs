#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KE_PRCB_RCU_DATA
    {
        [FieldOffset(0)]
        public uint NestingLevel;
        [FieldOffset(4)]
        public byte DispatchPin;
        [FieldOffset(5)]
        public byte GracePeriodNeeded;
        [FieldOffset(6)]
        public byte ExpediteReporting;
        [FieldOffset(7)]
        public sbyte IdleState;
        [FieldOffset(8)]
        public ulong GraceSequenceQuiescent;
        [FieldOffset(16)]
        public ulong GraceSequenceReported;
        [FieldOffset(24)]
        public IntPtr AwaitingCompletion;
    }
}