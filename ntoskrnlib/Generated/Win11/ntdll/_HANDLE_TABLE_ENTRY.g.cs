#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HANDLE_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public long VolatileLowValue;
        [FieldOffset(0)]
        public long LowValue;
        [FieldOffset(0)]
        public IntPtr InfoTable;
        [FieldOffset(8)]
        public long HighValue;
        [FieldOffset(8)]
        public IntPtr NextFreeHandleEntry;
        [FieldOffset(8)]
        public _EXHANDLE LeafHandleValue;
        [FieldOffset(0)]
        public long RefCountField;
        [FieldOffset(0)]
        public ulong Unlocked;
        [FieldOffset(0)]
        public ulong RefCnt;
        [FieldOffset(0)]
        public ulong Attributes;
        [FieldOffset(0)]
        public ulong ObjectPointerBits;
        [FieldOffset(8)]
        public uint GrantedAccessBits;
        [FieldOffset(8)]
        public uint NoRightsUpgrade;
        [FieldOffset(8)]
        public uint Spare1;
        [FieldOffset(12)]
        public uint Spare2;
    }
}