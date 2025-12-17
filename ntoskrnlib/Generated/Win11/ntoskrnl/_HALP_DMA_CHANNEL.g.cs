#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _HALP_DMA_CHANNEL
    {
        [FieldOffset(0)]
        public uint ChannelNumber;
        [FieldOffset(4)]
        public byte Initialized;
        [FieldOffset(5)]
        public byte Busy;
        [FieldOffset(6)]
        public byte Complete;
        [FieldOffset(8)]
        public IntPtr CurrentCompletionRoutine;
        [FieldOffset(16)]
        public IntPtr CurrentCompletionContext;
        [FieldOffset(24)]
        public IntPtr CurrentChildAdapter;
        [FieldOffset(32)]
        public uint CurrentInterruptType;
        [FieldOffset(40)]
        public _KDPC Dpc;
        [FieldOffset(104)]
        public byte GeneratesInterrupt;
        [FieldOffset(108)]
        public int Gsi;
        [FieldOffset(112)]
        public uint InterruptPolarity;
        [FieldOffset(116)]
        public uint InterruptMode;
        [FieldOffset(120)]
        public uint CommonBufferLength;
        [FieldOffset(128)]
        public IntPtr CommonBufferVirtualAddress;
        [FieldOffset(136)]
        public _LARGE_INTEGER CommonBufferLogicalAddress;
        [FieldOffset(144)]
        public _LIST_ENTRY AdapterQueue;
    }
}