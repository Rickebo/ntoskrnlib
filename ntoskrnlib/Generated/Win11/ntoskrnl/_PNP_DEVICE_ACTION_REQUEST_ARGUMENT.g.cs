#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PNP_DEVICE_ACTION_REQUEST_ARGUMENT
    {
        [FieldOffset(0)]
        public IntPtr PdcActivatorHandle;
        [FieldOffset(8)]
        public _unnamed_tag_ u;
    }
}