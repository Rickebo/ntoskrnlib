#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMSUPPORT_FLAGS
    {
        [FieldOffset(0)]
        public byte WorkingSetType;
        [FieldOffset(0)]
        public byte Reserved0;
        [FieldOffset(0)]
        public byte MaximumWorkingSetHard;
        [FieldOffset(0)]
        public byte MinimumWorkingSetHard;
        [FieldOffset(1)]
        public byte Reserved1;
        [FieldOffset(1)]
        public byte TrimmerState;
        [FieldOffset(1)]
        public byte LinearAddressProtected;
        [FieldOffset(1)]
        public byte PageStealers;
        [FieldOffset(0)]
        public ushort u1;
        [FieldOffset(2)]
        public byte MemoryPriority;
        [FieldOffset(3)]
        public byte WsleDeleted;
        [FieldOffset(3)]
        public byte SvmEnabled;
        [FieldOffset(3)]
        public byte ForceAge;
        [FieldOffset(3)]
        public byte ForceTrim;
        [FieldOffset(3)]
        public byte CommitReleaseState;
        [FieldOffset(3)]
        public byte Reserved2;
        [FieldOffset(3)]
        public byte u2;
        [FieldOffset(0)]
        public uint EntireFlags;
    }
}