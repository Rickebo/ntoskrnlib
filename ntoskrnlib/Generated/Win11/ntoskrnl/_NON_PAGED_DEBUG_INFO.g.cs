#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _NON_PAGED_DEBUG_INFO
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        public ushort Machine;
        [FieldOffset(10)]
        public ushort Characteristics;
        [FieldOffset(12)]
        public uint TimeDateStamp;
        [FieldOffset(16)]
        public uint CheckSum;
        [FieldOffset(20)]
        public uint SizeOfImage;
        [FieldOffset(24)]
        public ulong ImageBase;
    }
}