#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _INTERRUPT_LINES
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint ControllerId;
        [FieldOffset(20)]
        public int MinLine;
        [FieldOffset(24)]
        public int MaxLine;
        [FieldOffset(28)]
        public uint GsiBase;
        [FieldOffset(32)]
        public uint Type;
        [FieldOffset(36)]
        public uint SubType;
        [FieldOffset(40)]
        public IntPtr State;
        [FieldOffset(48)]
        public IntPtr InternalState;
        [FieldOffset(56)]
        public ulong MsiAddress;
        [FieldOffset(64)]
        public uint MsiData;
        [FieldOffset(72)]
        public _RTL_BITMAP MsiInUse;
    }
}