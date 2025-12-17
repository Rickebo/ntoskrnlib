#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _EVENT_RECORD
    {
        [FieldOffset(0)]
        public _EVENT_HEADER EventHeader;
        [FieldOffset(80)]
        public _ETW_BUFFER_CONTEXT BufferContext;
        [FieldOffset(84)]
        public ushort ExtendedDataCount;
        [FieldOffset(86)]
        public ushort UserDataLength;
        [FieldOffset(88)]
        public IntPtr ExtendedData;
        [FieldOffset(96)]
        public IntPtr UserData;
        [FieldOffset(104)]
        public IntPtr UserContext;
    }
}