#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MIPFNBLINK
    {
        [FieldOffset(0)]
        public ulong Blink;
        [FieldOffset(0)]
        public ulong NodeBlinkLow;
        [FieldOffset(0)]
        public ulong TbFlushStamp;
        [FieldOffset(0)]
        public ulong PageBlinkDeleteBit;
        [FieldOffset(0)]
        public ulong PageBlinkLockBit;
        [FieldOffset(0)]
        public ulong ShareCount;
        [FieldOffset(0)]
        public ulong PageShareCountDeleteBit;
        [FieldOffset(0)]
        public ulong PageShareCountLockBit;
        [FieldOffset(0)]
        public long EntireField;
        [FieldOffset(0)]
        public ulong LockNotUsed;
        [FieldOffset(0)]
        public ulong DeleteBit;
        [FieldOffset(0)]
        public ulong LockBit;
    }
}