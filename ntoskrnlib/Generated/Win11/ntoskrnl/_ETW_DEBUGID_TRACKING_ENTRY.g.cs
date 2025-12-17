#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _ETW_DEBUGID_TRACKING_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public byte ConsumersNotified;
        [FieldOffset(17)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare;
        [FieldOffset(20)]
        public uint DebugIdSize;
        [FieldOffset(24)]
        public _CVDD DebugId;
    }
}