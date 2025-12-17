#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTL_STD_LIST_HEAD
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public _RTL_STACK_DATABASE_LOCK Lock;
    }
}