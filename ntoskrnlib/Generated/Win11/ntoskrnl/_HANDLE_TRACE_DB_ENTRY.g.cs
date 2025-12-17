#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _HANDLE_TRACE_DB_ENTRY
    {
        [FieldOffset(0)]
        public _CLIENT_ID ClientId;
        [FieldOffset(16)]
        public IntPtr Handle;
        [FieldOffset(24)]
        public uint Type;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public IntPtr[] StackTrace;
    }
}