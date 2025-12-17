#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct __WIL__WNF_TYPE_ID
    {
        [FieldOffset(0)]
        public _GUID TypeId;
    }
}