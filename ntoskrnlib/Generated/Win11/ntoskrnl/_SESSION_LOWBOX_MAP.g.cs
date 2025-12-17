#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _SESSION_LOWBOX_MAP
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint SessionId;
        [FieldOffset(24)]
        public _SEP_LOWBOX_NUMBER_MAPPING LowboxMap;
    }
}