#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EVENT_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Id;
        [FieldOffset(2)]
        public byte Version;
        [FieldOffset(3)]
        public byte Channel;
        [FieldOffset(4)]
        public byte Level;
        [FieldOffset(5)]
        public byte Opcode;
        [FieldOffset(6)]
        public ushort Task;
        [FieldOffset(8)]
        public ulong Keyword;
    }
}