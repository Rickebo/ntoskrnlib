#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _PEBS_DS_SAVE_AREA
    {
        [FieldOffset(0)]
        public _PEBS_DS_SAVE_AREA32 As32Bit;
        [FieldOffset(0)]
        public _PEBS_DS_SAVE_AREA64 As64Bit;
    }
}