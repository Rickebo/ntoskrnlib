#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _SECONDARY_IC_LIST_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint GsivBase;
        [FieldOffset(20)]
        public uint GsivSize;
        [FieldOffset(24)]
        public _SECONDARY_INTERRUPT_PROVIDER_INTERFACE Interface;
        [FieldOffset(112)]
        public int BusyCount;
        [FieldOffset(116)]
        public int ExclusiveWaiterCount;
        [FieldOffset(120)]
        public _KEVENT NotificationEvent;
        [FieldOffset(144)]
        public _LIST_ENTRY SignalListEntry;
        [FieldOffset(160)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _SECONDARY_INTERRUPT_LINE_STATE[] State;
    }
}