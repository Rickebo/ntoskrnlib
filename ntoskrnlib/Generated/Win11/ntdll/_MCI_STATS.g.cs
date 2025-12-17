#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCI_STATS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ MciStatus;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}