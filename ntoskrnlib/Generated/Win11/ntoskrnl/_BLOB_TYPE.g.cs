#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _BLOB_TYPE
    {
        [FieldOffset(0)]
        public uint ResourceId;
        [FieldOffset(4)]
        public uint PoolTag;
        [FieldOffset(8)]
        public uint LookasideIndex;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public IntPtr Counters;
        [FieldOffset(24)]
        public IntPtr CleanupProcedure;
        [FieldOffset(32)]
        public IntPtr DeleteProcedure;
        [FieldOffset(40)]
        public IntPtr DestroyProcedure;
        [FieldOffset(48)]
        public ulong UsualSize;
    }
}