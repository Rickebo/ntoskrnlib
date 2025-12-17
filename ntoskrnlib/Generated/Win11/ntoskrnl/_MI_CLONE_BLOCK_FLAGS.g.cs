#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_CLONE_BLOCK_FLAGS
    {
        [FieldOffset(0)]
        public ulong CloneProtection;
        [FieldOffset(0)]
        public ulong ReducedCommitReferences;
        [FieldOffset(0)]
        public ulong ScpPage;
        [FieldOffset(0)]
        public ulong Spare;
        [FieldOffset(0)]
        public ulong LockBit;
        [FieldOffset(0)]
        public long EntireField;
    }
}