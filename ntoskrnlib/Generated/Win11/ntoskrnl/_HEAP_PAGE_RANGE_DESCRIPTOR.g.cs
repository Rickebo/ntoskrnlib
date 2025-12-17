#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HEAP_PAGE_RANGE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE TreeNode;
        [FieldOffset(0)]
        public uint TreeSignature;
        [FieldOffset(4)]
        public uint UnusedBytes;
        [FieldOffset(8)]
        public ushort ExtraPresent;
        [FieldOffset(8)]
        public ushort Spare0;
        [FieldOffset(24)]
        public byte RangeFlags;
        [FieldOffset(25)]
        public byte CommittedPageCount;
        [FieldOffset(26)]
        public byte UnitOffset;
        [FieldOffset(27)]
        public byte Spare;
        [FieldOffset(28)]
        public _HEAP_DESCRIPTOR_KEY Key;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Align;
        [FieldOffset(31)]
        public byte UnitSize;
    }
}