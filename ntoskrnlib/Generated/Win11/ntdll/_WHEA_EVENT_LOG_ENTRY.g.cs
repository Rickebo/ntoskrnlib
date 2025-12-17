#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _WHEA_EVENT_LOG_ENTRY
    {
        [FieldOffset(0)]
        public _WHEA_EVENT_LOG_ENTRY_HEADER Header;
    }
}