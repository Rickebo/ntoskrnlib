#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KQOS_GROUPING_SETS
    {
        [FieldOffset(0)]
        public ulong SingleCoreSet;
        [FieldOffset(8)]
        public ulong SmtSet;
    }
}