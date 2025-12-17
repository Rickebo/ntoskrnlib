#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public partial struct _LOCAL_NMISOURCE
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public byte ProcessorID;
        [FieldOffset(3)]
        public ushort Flags;
        [FieldOffset(5)]
        public byte LINTIN;
    }
}