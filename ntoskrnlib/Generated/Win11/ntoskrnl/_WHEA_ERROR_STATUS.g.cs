#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_ERROR_STATUS
    {
        [FieldOffset(0)]
        public ulong ErrorStatus;
        [FieldOffset(0)]
        public ulong Reserved1;
        [FieldOffset(0)]
        public ulong ErrorType;
        [FieldOffset(0)]
        public ulong Address;
        [FieldOffset(0)]
        public ulong Control;
        [FieldOffset(0)]
        public ulong Data;
        [FieldOffset(0)]
        public ulong Responder;
        [FieldOffset(0)]
        public ulong Requester;
        [FieldOffset(0)]
        public ulong FirstError;
        [FieldOffset(0)]
        public ulong Overflow;
        [FieldOffset(0)]
        public ulong Reserved2;
    }
}