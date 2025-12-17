#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _ARBITER_LIST_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint AlternativeCount;
        [FieldOffset(24)]
        public IntPtr Alternatives;
        [FieldOffset(32)]
        public IntPtr PhysicalDeviceObject;
        [FieldOffset(40)]
        public uint RequestSource;
        [FieldOffset(44)]
        public uint Flags;
        [FieldOffset(48)]
        public long WorkSpace;
        [FieldOffset(56)]
        public uint InterfaceType;
        [FieldOffset(60)]
        public uint SlotNumber;
        [FieldOffset(64)]
        public uint BusNumber;
        [FieldOffset(72)]
        public IntPtr Assignment;
        [FieldOffset(80)]
        public IntPtr SelectedAlternative;
        [FieldOffset(88)]
        public uint Result;
    }
}