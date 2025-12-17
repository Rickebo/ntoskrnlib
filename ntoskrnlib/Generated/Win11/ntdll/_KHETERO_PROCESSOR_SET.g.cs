#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KHETERO_PROCESSOR_SET
    {
        [FieldOffset(0)]
        public ulong IdealMask;
        [FieldOffset(8)]
        public ulong PreferredMask;
        [FieldOffset(16)]
        public ulong AvailableMask;
    }
}