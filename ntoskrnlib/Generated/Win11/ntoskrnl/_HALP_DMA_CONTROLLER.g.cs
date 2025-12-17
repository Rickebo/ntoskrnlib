#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _HALP_DMA_CONTROLLER
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Controllers;
        [FieldOffset(16)]
        public _LIST_ENTRY AdapterList;
        [FieldOffset(32)]
        public uint ControllerId;
        [FieldOffset(36)]
        public uint MinimumRequestLine;
        [FieldOffset(40)]
        public uint MaximumRequestLine;
        [FieldOffset(44)]
        public uint ChannelCount;
        [FieldOffset(48)]
        public uint ScatterGatherLimit;
        [FieldOffset(56)]
        public IntPtr Channels;
        [FieldOffset(64)]
        public IntPtr ExtensionData;
        [FieldOffset(72)]
        public byte CacheCoherent;
        [FieldOffset(76)]
        public uint DmaAddressWidth;
        [FieldOffset(80)]
        public _DMA_FUNCTION_TABLE Operations;
        [FieldOffset(160)]
        public uint SupportedPortWidths;
        [FieldOffset(164)]
        public uint MinimumTransferUnit;
        [FieldOffset(168)]
        public ulong Lock;
        [FieldOffset(176)]
        public byte Irql;
        [FieldOffset(177)]
        public byte GeneratesInterrupt;
        [FieldOffset(180)]
        public int Gsi;
        [FieldOffset(184)]
        public uint InterruptPolarity;
        [FieldOffset(188)]
        public uint InterruptMode;
        [FieldOffset(192)]
        public _UNICODE_STRING ResourceId;
        [FieldOffset(208)]
        public IntPtr PowerHandle;
        [FieldOffset(216)]
        public byte PowerActive;
    }
}