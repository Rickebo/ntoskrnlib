#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DBGKD_LOAD_SYMBOLS32
    {
        [FieldOffset(0)]
        public uint PathNameLength;
        [FieldOffset(4)]
        public uint BaseOfDll;
        [FieldOffset(8)]
        public uint ProcessId;
        [FieldOffset(12)]
        public uint CheckSum;
        [FieldOffset(16)]
        public uint SizeOfImage;
        [FieldOffset(20)]
        public byte UnloadSymbols;
    }
}