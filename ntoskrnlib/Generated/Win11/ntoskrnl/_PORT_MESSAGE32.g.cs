#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PORT_MESSAGE32
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(4)]
        public _unnamed_tag_ u2;
        [FieldOffset(8)]
        public _CLIENT_ID32 ClientId;
        [FieldOffset(8)]
        public long DoNotUseThisField;
        [FieldOffset(16)]
        public uint MessageId;
        [FieldOffset(20)]
        public uint ClientViewSize;
        [FieldOffset(20)]
        public uint CallbackId;
    }
}