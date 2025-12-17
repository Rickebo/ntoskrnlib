#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 384)]
    public partial struct _PO_DEVICE_NOTIFY_ORDER
    {
        [FieldOffset(0)]
        public byte Locked;
        [FieldOffset(8)]
        public IntPtr WarmEjectPdoPointer;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public _PO_NOTIFY_ORDER_LEVEL[] OrderLevel;
        [FieldOffset(376)]
        public uint Flags;
    }
}