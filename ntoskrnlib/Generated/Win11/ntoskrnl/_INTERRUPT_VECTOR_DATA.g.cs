#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _INTERRUPT_VECTOR_DATA
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint Vector;
        [FieldOffset(8)]
        public byte Irql;
        [FieldOffset(12)]
        public uint Polarity;
        [FieldOffset(16)]
        public uint Mode;
        [FieldOffset(24)]
        public _GROUP_AFFINITY TargetProcessors;
        [FieldOffset(40)]
        public _INTERRUPT_REMAPPING_INFO IntRemapInfo;
        [FieldOffset(56)]
        public _unnamed_tag_ ControllerInput;
        [FieldOffset(64)]
        public ulong HvDeviceId;
        [FieldOffset(72)]
        public _unnamed_tag_ XapicMessage;
        [FieldOffset(72)]
        public _unnamed_tag_ Hypertransport;
        [FieldOffset(72)]
        public _unnamed_tag_ GenericMessage;
        [FieldOffset(72)]
        public _unnamed_tag_ MessageRequest;
    }
}