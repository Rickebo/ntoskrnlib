#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _MBCB
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeIsInZone;
        [FieldOffset(4)]
        public uint PagesToWrite;
        [FieldOffset(8)]
        public uint DirtyPages;
        [FieldOffset(12)]
        public uint Reserved;
        [FieldOffset(16)]
        public _LIST_ENTRY BitmapRanges;
        [FieldOffset(32)]
        public long ResumeWritePage;
        [FieldOffset(40)]
        public long MostRecentlyDirtiedPage;
        [FieldOffset(48)]
        public _BITMAP_RANGE BitmapRange1;
        [FieldOffset(96)]
        public _BITMAP_RANGE BitmapRange2;
        [FieldOffset(144)]
        public _BITMAP_RANGE BitmapRange3;
    }
}