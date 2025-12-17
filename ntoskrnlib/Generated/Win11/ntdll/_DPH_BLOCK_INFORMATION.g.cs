#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _DPH_BLOCK_INFORMATION
    {
        [FieldOffset(0)]
        public uint StartStamp;
        [FieldOffset(8)]
        public IntPtr Heap;
        [FieldOffset(16)]
        public ulong RequestedSize;
        [FieldOffset(24)]
        public ulong ActualSize;
        [FieldOffset(32)]
        public _LIST_ENTRY FreeQueue;
        [FieldOffset(32)]
        public _SLIST_ENTRY FreePushList;
        [FieldOffset(32)]
        public ushort TraceIndex;
        [FieldOffset(48)]
        public IntPtr StackTrace;
        [FieldOffset(56)]
        public uint Padding;
        [FieldOffset(60)]
        public uint EndStamp;
    }
}