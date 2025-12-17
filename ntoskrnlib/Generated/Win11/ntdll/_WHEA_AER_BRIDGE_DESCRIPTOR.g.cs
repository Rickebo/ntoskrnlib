#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial struct _WHEA_AER_BRIDGE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public byte Enabled;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public uint BusNumber;
        [FieldOffset(8)]
        public _WHEA_PCI_SLOT_NUMBER Slot;
        [FieldOffset(12)]
        public ushort DeviceControl;
        [FieldOffset(14)]
        public _AER_BRIDGE_DESCRIPTOR_FLAGS Flags;
        [FieldOffset(16)]
        public uint UncorrectableErrorMask;
        [FieldOffset(20)]
        public uint UncorrectableErrorSeverity;
        [FieldOffset(24)]
        public uint CorrectableErrorMask;
        [FieldOffset(28)]
        public uint AdvancedCapsAndControl;
        [FieldOffset(32)]
        public uint SecondaryUncorrectableErrorMask;
        [FieldOffset(36)]
        public uint SecondaryUncorrectableErrorSev;
        [FieldOffset(40)]
        public uint SecondaryCapsAndControl;
    }
}