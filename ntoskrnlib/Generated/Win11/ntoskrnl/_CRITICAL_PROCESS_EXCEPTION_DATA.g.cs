#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _CRITICAL_PROCESS_EXCEPTION_DATA
    {
        [FieldOffset(0)]
        public _GUID ReportId;
        [FieldOffset(16)]
        public _UNICODE_STRING ModuleName;
        [FieldOffset(32)]
        public uint ModuleTimestamp;
        [FieldOffset(36)]
        public uint ModuleSize;
        [FieldOffset(40)]
        public ulong Offset;
    }
}