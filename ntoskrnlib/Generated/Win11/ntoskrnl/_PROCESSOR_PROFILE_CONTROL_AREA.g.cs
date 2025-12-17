#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _PROCESSOR_PROFILE_CONTROL_AREA
    {
        [FieldOffset(0)]
        public _PEBS_DS_SAVE_AREA PebsDsSaveArea;
        [FieldOffset(0)]
        public IntPtr RawBuffer;
    }
}