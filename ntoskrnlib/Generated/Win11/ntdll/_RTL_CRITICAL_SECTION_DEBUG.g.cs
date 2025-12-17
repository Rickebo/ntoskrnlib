#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _RTL_CRITICAL_SECTION_DEBUG
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public ushort CreatorBackTraceIndex;
        [FieldOffset(8)]
        public IntPtr CriticalSection;
        [FieldOffset(16)]
        public _LIST_ENTRY ProcessLocksList;
        [FieldOffset(32)]
        public uint EntryCount;
        [FieldOffset(36)]
        public uint ContentionCount;
        [FieldOffset(40)]
        public uint Flags;
        [FieldOffset(44)]
        public ushort CreatorBackTraceIndexHigh;
        [FieldOffset(46)]
        public ushort Identifier;
    }
}