#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _MMPFNENTRY1
    {
        [FieldOffset(0)]
        public byte PageLocation;
        [FieldOffset(0)]
        public byte WriteInProgress;
        [FieldOffset(0)]
        public byte Modified;
        [FieldOffset(0)]
        public byte ReadInProgress;
        [FieldOffset(0)]
        public byte CacheAttribute;
    }
}