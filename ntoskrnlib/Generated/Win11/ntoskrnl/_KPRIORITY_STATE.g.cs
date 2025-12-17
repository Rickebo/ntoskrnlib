#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KPRIORITY_STATE
    {
        [FieldOffset(0)]
        public byte Priority;
        [FieldOffset(0)]
        public byte IsolationWidth;
        [FieldOffset(0)]
        public byte AllFields;
    }
}