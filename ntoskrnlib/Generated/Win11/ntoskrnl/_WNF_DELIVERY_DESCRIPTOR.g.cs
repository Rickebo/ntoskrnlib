#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _WNF_DELIVERY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ulong SubscriptionId;
        [FieldOffset(8)]
        public _WNF_STATE_NAME StateName;
        [FieldOffset(16)]
        public uint ChangeStamp;
        [FieldOffset(20)]
        public uint StateDataSize;
        [FieldOffset(24)]
        public uint EventMask;
        [FieldOffset(28)]
        public _WNF_TYPE_ID TypeId;
        [FieldOffset(44)]
        public uint StateDataOffset;
    }
}