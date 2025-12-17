#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _VF_WATCHDOG_IRP
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public uint DueTickCount;
        [FieldOffset(28)]
        public byte Inserted;
        [FieldOffset(29)]
        public sbyte TrackedStackLocation;
        [FieldOffset(30)]
        public ushort CancelTimeoutTicks;
    }
}