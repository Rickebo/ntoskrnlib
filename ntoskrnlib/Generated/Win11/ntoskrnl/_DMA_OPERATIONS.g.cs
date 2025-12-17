#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public partial struct _DMA_OPERATIONS
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(8)]
        public IntPtr PutDmaAdapter;
        [FieldOffset(16)]
        public IntPtr AllocateCommonBuffer;
        [FieldOffset(24)]
        public IntPtr FreeCommonBuffer;
        [FieldOffset(32)]
        public IntPtr AllocateAdapterChannel;
        [FieldOffset(40)]
        public IntPtr FlushAdapterBuffers;
        [FieldOffset(48)]
        public IntPtr FreeAdapterChannel;
        [FieldOffset(56)]
        public IntPtr FreeMapRegisters;
        [FieldOffset(64)]
        public IntPtr MapTransfer;
        [FieldOffset(72)]
        public IntPtr GetDmaAlignment;
        [FieldOffset(80)]
        public IntPtr ReadDmaCounter;
        [FieldOffset(88)]
        public IntPtr GetScatterGatherList;
        [FieldOffset(96)]
        public IntPtr PutScatterGatherList;
        [FieldOffset(104)]
        public IntPtr CalculateScatterGatherList;
        [FieldOffset(112)]
        public IntPtr BuildScatterGatherList;
        [FieldOffset(120)]
        public IntPtr BuildMdlFromScatterGatherList;
        [FieldOffset(128)]
        public IntPtr GetDmaAdapterInfo;
        [FieldOffset(136)]
        public IntPtr GetDmaTransferInfo;
        [FieldOffset(144)]
        public IntPtr InitializeDmaTransferContext;
        [FieldOffset(152)]
        public IntPtr AllocateCommonBufferEx;
        [FieldOffset(160)]
        public IntPtr AllocateAdapterChannelEx;
        [FieldOffset(168)]
        public IntPtr ConfigureAdapterChannel;
        [FieldOffset(176)]
        public IntPtr CancelAdapterChannel;
        [FieldOffset(184)]
        public IntPtr MapTransferEx;
        [FieldOffset(192)]
        public IntPtr GetScatterGatherListEx;
        [FieldOffset(200)]
        public IntPtr BuildScatterGatherListEx;
        [FieldOffset(208)]
        public IntPtr FlushAdapterBuffersEx;
        [FieldOffset(216)]
        public IntPtr FreeAdapterObject;
        [FieldOffset(224)]
        public IntPtr CancelMappedTransfer;
        [FieldOffset(232)]
        public IntPtr AllocateDomainCommonBuffer;
        [FieldOffset(240)]
        public IntPtr FlushDmaBuffer;
        [FieldOffset(248)]
        public IntPtr JoinDmaDomain;
        [FieldOffset(256)]
        public IntPtr LeaveDmaDomain;
        [FieldOffset(264)]
        public IntPtr GetDmaDomain;
        [FieldOffset(272)]
        public IntPtr AllocateCommonBufferWithBounds;
        [FieldOffset(280)]
        public IntPtr AllocateCommonBufferVector;
        [FieldOffset(288)]
        public IntPtr GetCommonBufferFromVectorByIndex;
        [FieldOffset(296)]
        public IntPtr FreeCommonBufferFromVector;
        [FieldOffset(304)]
        public IntPtr FreeCommonBufferVector;
        [FieldOffset(312)]
        public IntPtr CreateCommonBufferFromMdl;
    }
}