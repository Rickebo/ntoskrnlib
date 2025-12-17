#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _RTL_STACK_TRACE_ENTRY
    {
        [FieldOffset(0)]
        public _RTL_STD_LIST_ENTRY HashChain;
        [FieldOffset(8)]
        public ushort TraceCount;
        [FieldOffset(8)]
        public ushort BlockDepth;
        [FieldOffset(10)]
        public ushort IndexHigh;
        [FieldOffset(12)]
        public ushort Index;
        [FieldOffset(14)]
        public ushort Depth;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public IntPtr[] BackTrace;
        [FieldOffset(16)]
        public _SLIST_ENTRY FreeChain;
    }
}