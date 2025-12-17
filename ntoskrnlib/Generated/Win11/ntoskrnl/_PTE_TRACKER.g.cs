#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _PTE_TRACKER
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr Mdl;
        [FieldOffset(24)]
        public ulong Count;
        [FieldOffset(32)]
        public IntPtr SystemVa;
        [FieldOffset(40)]
        public IntPtr StartVa;
        [FieldOffset(48)]
        public uint Offset;
        [FieldOffset(52)]
        public uint Length;
        [FieldOffset(56)]
        public ulong Page;
        [FieldOffset(64)]
        public uint IoMapping;
        [FieldOffset(64)]
        public uint Matched;
        [FieldOffset(64)]
        public uint CacheAttribute;
        [FieldOffset(64)]
        public uint GuardPte;
        [FieldOffset(64)]
        public uint Spare;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public IntPtr[] StackTrace;
    }
}