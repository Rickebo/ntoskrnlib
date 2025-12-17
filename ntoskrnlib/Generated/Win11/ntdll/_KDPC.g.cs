#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KDPC
    {
        [FieldOffset(0)]
        public uint TargetInfoAsUlong;
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Importance;
        [FieldOffset(2)]
        public ushort Number;
        [FieldOffset(8)]
        public _SINGLE_LIST_ENTRY DpcListEntry;
        [FieldOffset(16)]
        public ulong ProcessorHistory;
        [FieldOffset(24)]
        public IntPtr DeferredRoutine;
        [FieldOffset(32)]
        public IntPtr DeferredContext;
        [FieldOffset(40)]
        public IntPtr SystemArgument1;
        [FieldOffset(48)]
        public IntPtr SystemArgument2;
        [FieldOffset(56)]
        public IntPtr DpcData;
    }
}