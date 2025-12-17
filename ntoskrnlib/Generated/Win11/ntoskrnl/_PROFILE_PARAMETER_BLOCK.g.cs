#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROFILE_PARAMETER_BLOCK
    {
        [FieldOffset(0)]
        public ushort Status;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public ushort DockingState;
        [FieldOffset(6)]
        public ushort Capabilities;
        [FieldOffset(8)]
        public uint DockID;
        [FieldOffset(12)]
        public uint SerialNumber;
    }
}