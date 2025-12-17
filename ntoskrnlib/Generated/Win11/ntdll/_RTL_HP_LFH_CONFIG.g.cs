#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _RTL_HP_LFH_CONFIG
    {
        [FieldOffset(0)]
        public ushort MaxBlockSize;
        [FieldOffset(2)]
        public ushort WitholdPageCrossingBlocks;
        [FieldOffset(0)]
        public uint AllFields;
    }
}