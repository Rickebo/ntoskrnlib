#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _CACHE_MANAGER_CALLBACKS_EX
    {
        [FieldOffset(0)]
        public ushort Version;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(8)]
        public _CACHE_MANAGER_CALLBACK_FUNCTIONS Functions;
    }
}