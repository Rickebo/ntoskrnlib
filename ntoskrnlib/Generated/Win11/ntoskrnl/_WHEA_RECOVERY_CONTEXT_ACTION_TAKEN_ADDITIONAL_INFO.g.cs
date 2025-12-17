#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Bits;
        [FieldOffset(0)]
        public ulong AsULONG64;
    }
}