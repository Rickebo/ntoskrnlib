#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _CONTROLLER_OBJECT
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public IntPtr ControllerExtension;
        [FieldOffset(16)]
        public _KDEVICE_QUEUE DeviceWaitQueue;
        [FieldOffset(56)]
        public uint Spare1;
        [FieldOffset(64)]
        public _LARGE_INTEGER Spare2;
    }
}