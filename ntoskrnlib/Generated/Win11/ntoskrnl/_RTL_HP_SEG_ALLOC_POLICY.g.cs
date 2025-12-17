#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_HP_SEG_ALLOC_POLICY
    {
        [FieldOffset(0)]
        public ulong MinLargePages;
        [FieldOffset(8)]
        public ulong MaxLargePages;
        [FieldOffset(16)]
        public byte MinUtilization;
    }
}