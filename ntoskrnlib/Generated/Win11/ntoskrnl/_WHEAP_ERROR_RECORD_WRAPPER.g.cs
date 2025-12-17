#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public partial struct _WHEAP_ERROR_RECORD_WRAPPER
    {
        [FieldOffset(0)]
        public _LIST_ENTRY WorkEntry;
        [FieldOffset(16)]
        public uint Length;
        [FieldOffset(20)]
        public uint ProcessorNumber;
        [FieldOffset(24)]
        public _WHEAP_ERROR_RECORD_WRAPPER_FLAGS Flags;
        [FieldOffset(28)]
        public int InUse;
        [FieldOffset(32)]
        public IntPtr ErrorSource;
        [FieldOffset(40)]
        public _WHEA_ERROR_RECORD ErrorRecord;
    }
}