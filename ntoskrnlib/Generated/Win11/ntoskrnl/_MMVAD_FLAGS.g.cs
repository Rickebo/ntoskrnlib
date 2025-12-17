#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMVAD_FLAGS
    {
        [FieldOffset(0)]
        public uint Lock;
        [FieldOffset(0)]
        public uint LockContended;
        [FieldOffset(0)]
        public uint DeleteInProgress;
        [FieldOffset(0)]
        public uint NoChange;
        [FieldOffset(0)]
        public uint VadType;
        [FieldOffset(0)]
        public uint Protection;
        [FieldOffset(0)]
        public uint PreferredNode;
        [FieldOffset(0)]
        public uint PageSize;
        [FieldOffset(0)]
        public uint PrivateMemory;
        [FieldOffset(0)]
        public uint EntireField;
    }
}