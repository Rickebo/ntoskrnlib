#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ALPC_COMPLETION_LIST_STATE
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
    }
}