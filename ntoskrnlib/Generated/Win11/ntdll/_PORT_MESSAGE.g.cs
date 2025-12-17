#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PORT_MESSAGE
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(4)]
        public _unnamed_tag_ u2;
        [FieldOffset(8)]
        public _CLIENT_ID ClientId;
        [FieldOffset(8)]
        public long DoNotUseThisField;
        [FieldOffset(24)]
        public uint MessageId;
        [FieldOffset(32)]
        public ulong ClientViewSize;
        [FieldOffset(32)]
        public uint CallbackId;
    }
}