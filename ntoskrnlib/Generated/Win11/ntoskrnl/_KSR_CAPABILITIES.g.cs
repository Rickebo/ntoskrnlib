#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KSR_CAPABILITIES
    {
        [FieldOffset(0)]
        public uint PerennialDatabase;
        [FieldOffset(0)]
        public uint SkipSubAllocator;
        [FieldOffset(0)]
        public uint ExtendedNotifications;
        [FieldOffset(0)]
        public uint Kseg0Vtl1Mappings64KBAligned;
        [FieldOffset(0)]
        public uint Vtl1IsolatedDatabase;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULong;
    }
}