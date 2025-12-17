#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DBGKD_LOAD_SYMBOLS64
    {
        [FieldOffset(0)]
        public uint PathNameLength;
        [FieldOffset(8)]
        public ulong BaseOfDll;
        [FieldOffset(16)]
        public ulong ProcessId;
        [FieldOffset(24)]
        public uint CheckSum;
        [FieldOffset(28)]
        public uint SizeOfImage;
        [FieldOffset(32)]
        public byte UnloadSymbols;
    }
}