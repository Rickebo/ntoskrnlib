#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXP_PULLED_FILE_TABLE
    {
        [FieldOffset(0)]
        public int NumberOfFiles;
        [FieldOffset(4)]
        public int TableSize;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Hashes;
    }
}