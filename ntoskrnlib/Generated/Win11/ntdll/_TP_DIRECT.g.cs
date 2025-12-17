#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _TP_DIRECT
    {
        [FieldOffset(0)]
        public _TP_TASK Task;
        [FieldOffset(32)]
        public ulong Lock;
        [FieldOffset(40)]
        public _LIST_ENTRY IoCompletionInformationList;
        [FieldOffset(56)]
        public IntPtr Callback;
        [FieldOffset(64)]
        public uint NumaNode;
        [FieldOffset(68)]
        public byte IdealProcessor;
    }
}