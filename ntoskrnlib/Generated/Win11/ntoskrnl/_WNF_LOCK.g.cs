#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WNF_LOCK
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK PushLock;
    }
}