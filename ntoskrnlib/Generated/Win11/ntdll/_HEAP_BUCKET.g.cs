#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_BUCKET
    {
        [FieldOffset(0)]
        public ushort BlockUnits;
        [FieldOffset(2)]
        public byte SizeIndex;
        [FieldOffset(3)]
        public byte UseAffinity;
        [FieldOffset(3)]
        public byte DebugFlags;
        [FieldOffset(3)]
        public byte Flags;
    }
}