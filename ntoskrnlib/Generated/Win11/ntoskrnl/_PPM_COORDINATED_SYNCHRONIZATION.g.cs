#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PPM_COORDINATED_SYNCHRONIZATION
    {
        [FieldOffset(0)]
        public int AsLong;
        [FieldOffset(0)]
        public uint EnterProcessor;
        [FieldOffset(0)]
        public uint ExitProcessor;
        [FieldOffset(0)]
        public uint Transition;
        [FieldOffset(0)]
        public uint Entered;
        [FieldOffset(0)]
        public uint EntryPriority;
    }
}