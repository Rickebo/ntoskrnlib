#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_COLOR
    {
        [FieldOffset(0)]
        public uint EntireField;
        [FieldOffset(0)]
        public uint Cache;
        [FieldOffset(0)]
        public uint Channel;
        [FieldOffset(0)]
        public uint Node;
        [FieldOffset(0)]
        public uint HighLow;
        [FieldOffset(0)]
        public uint LargePageIndex;
        [FieldOffset(0)]
        public uint CacheAttribute;
        [FieldOffset(0)]
        public uint ListName;
    }
}