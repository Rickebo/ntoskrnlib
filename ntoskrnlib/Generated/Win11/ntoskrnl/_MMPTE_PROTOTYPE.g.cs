#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MMPTE_PROTOTYPE
    {
        [FieldOffset(0)]
        public ulong Valid;
        [FieldOffset(0)]
        public ulong DemandFillProto;
        [FieldOffset(0)]
        public ulong HiberVerifyConverted;
        [FieldOffset(0)]
        public ulong ReadOnly;
        [FieldOffset(0)]
        public ulong SwizzleBit;
        [FieldOffset(0)]
        public ulong Protection;
        [FieldOffset(0)]
        public ulong Prototype;
        [FieldOffset(0)]
        public ulong Combined;
        [FieldOffset(0)]
        public ulong Unused1;
        [FieldOffset(0)]
        public long ProtoAddress;
    }
}