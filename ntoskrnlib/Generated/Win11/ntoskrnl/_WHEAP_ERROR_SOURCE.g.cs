#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1072)]
    public partial struct _WHEAP_ERROR_SOURCE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint FailedAllocations;
        [FieldOffset(20)]
        public uint PlatformErrorSourceId;
        [FieldOffset(24)]
        public int ErrorCount;
        [FieldOffset(28)]
        public uint RecordCount;
        [FieldOffset(32)]
        public uint RecordLength;
        [FieldOffset(36)]
        public uint PoolTag;
        [FieldOffset(40)]
        public uint Type;
        [FieldOffset(48)]
        public IntPtr Records;
        [FieldOffset(56)]
        public IntPtr Context;
        [FieldOffset(64)]
        public uint SectionCount;
        [FieldOffset(68)]
        public uint SectionLength;
        [FieldOffset(72)]
        public _LARGE_INTEGER TickCountAtLastError;
        [FieldOffset(80)]
        public uint AccumulatedErrors;
        [FieldOffset(84)]
        public uint TotalErrors;
        [FieldOffset(88)]
        public byte Deferred;
        [FieldOffset(92)]
        public int Busy;
        [FieldOffset(96)]
        public _WHEA_ERROR_SOURCE_DESCRIPTOR Descriptor;
    }
}