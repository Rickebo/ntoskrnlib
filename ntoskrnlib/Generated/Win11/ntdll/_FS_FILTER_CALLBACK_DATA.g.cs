#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _FS_FILTER_CALLBACK_DATA
    {
        [FieldOffset(0)]
        public uint SizeOfFsFilterCallbackData;
        [FieldOffset(4)]
        public byte Operation;
        [FieldOffset(5)]
        public byte Reserved;
        [FieldOffset(8)]
        public IntPtr DeviceObject;
        [FieldOffset(16)]
        public IntPtr FileObject;
        [FieldOffset(24)]
        public _FS_FILTER_PARAMETERS Parameters;
    }
}