#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _OBJECT_HEADER_CREATOR_INFO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY TypeList;
        [FieldOffset(16)]
        public IntPtr CreatorUniqueProcess;
        [FieldOffset(24)]
        public ushort CreatorBackTraceIndex;
        [FieldOffset(26)]
        public ushort Reserved1;
        [FieldOffset(28)]
        public uint Reserved2;
    }
}