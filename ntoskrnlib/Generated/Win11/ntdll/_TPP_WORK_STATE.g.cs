#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _TPP_WORK_STATE
    {
        [FieldOffset(0)]
        public int Exchange;
        [FieldOffset(0)]
        public uint Insertable;
        [FieldOffset(0)]
        public uint PendingCallbackCount;
    }
}