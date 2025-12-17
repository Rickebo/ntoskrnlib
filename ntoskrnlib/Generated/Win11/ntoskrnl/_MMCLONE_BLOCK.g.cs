#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MMCLONE_BLOCK
    {
        [FieldOffset(0)]
        public _MMPTE ProtoPte;
        [FieldOffset(8)]
        public ulong CrossPartitionReferences;
        [FieldOffset(16)]
        public _MI_CLONE_BLOCK_FLAGS u1;
        [FieldOffset(24)]
        public ulong UseCount;
    }
}