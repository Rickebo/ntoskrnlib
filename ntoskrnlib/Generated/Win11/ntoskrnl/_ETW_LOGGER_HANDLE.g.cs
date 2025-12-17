#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _ETW_LOGGER_HANDLE
    {
        [FieldOffset(0)]
        public byte DereferenceAndLeave;
    }
}