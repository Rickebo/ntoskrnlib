#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PPM_IDLE_SYNCHRONIZATION_STATE
    {
        [FieldOffset(0)]
        public int AsLong;
        [FieldOffset(0)]
        public int RefCount;
        [FieldOffset(0)]
        public uint State;
    }
}