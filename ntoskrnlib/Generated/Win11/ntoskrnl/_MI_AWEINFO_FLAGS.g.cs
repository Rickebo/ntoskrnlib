#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_AWEINFO_FLAGS
    {
        [FieldOffset(0)]
        public uint ProcessDefault;
        [FieldOffset(0)]
        public uint PagesLockInitialized;
        [FieldOffset(0)]
        public uint ZeroPagesOptional;
        [FieldOffset(0)]
        public uint IoSpace;
        [FieldOffset(0)]
        public uint LazyTbFlush;
        [FieldOffset(0)]
        public uint Unused;
        [FieldOffset(0)]
        public uint AllBits;
    }
}