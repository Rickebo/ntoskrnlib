#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 648)]
    public partial struct _ADAPTER_OBJECT
    {
        [FieldOffset(0)]
        public _HALP_DMA_ADAPTER_OBJECT AdapterObject;
        [FieldOffset(160)]
        public IntPtr MasterAdapter;
        [FieldOffset(168)]
        public _LIST_ENTRY WaitQueueEntry;
        [FieldOffset(184)]
        public _KDEVICE_QUEUE ChannelWaitQueue;
        [FieldOffset(184)]
        public ulong ResourceWaitLock;
        [FieldOffset(192)]
        public _LIST_ENTRY ResourceWaitQueue;
        [FieldOffset(208)]
        public _LIST_ENTRY ChannelResourceWaitQueue;
        [FieldOffset(224)]
        public byte ResourceQueueBusy;
        [FieldOffset(232)]
        public uint MapRegistersPerChannel;
        [FieldOffset(240)]
        public IntPtr MapRegisterBase;
        [FieldOffset(248)]
        public uint NumberOfMapRegisters;
        [FieldOffset(252)]
        public uint MaxTransferLength;
        [FieldOffset(256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] CrashDumpRegisterBase;
        [FieldOffset(272)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] NumberOfCrashDumpRegisters;
        [FieldOffset(280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] CrashDumpRegisterRefCount;
        [FieldOffset(288)]
        public _LIST_ENTRY AdapterCrashDumpList;
        [FieldOffset(304)]
        public IntPtr MapRegisterMdl;
        [FieldOffset(312)]
        public ulong MapRegisterMdlLock;
        [FieldOffset(320)]
        public _EX_PUSH_LOCK ExpiredLock;
        [FieldOffset(328)]
        public IntPtr AllocationHandle;
        [FieldOffset(336)]
        public IntPtr VirtualAddress;
        [FieldOffset(344)]
        public byte IsAllocationMdlBased;
        [FieldOffset(345)]
        public byte NoLocalPool;
        [FieldOffset(346)]
        public byte ExpiredFlag;
        [FieldOffset(352)]
        public IntPtr CurrentWcb;
        [FieldOffset(360)]
        public IntPtr CurrentTransferContext;
        [FieldOffset(368)]
        public IntPtr DmaController;
        [FieldOffset(376)]
        public uint Controller;
        [FieldOffset(380)]
        public uint ChannelNumber;
        [FieldOffset(384)]
        public uint RequestLine;
        [FieldOffset(388)]
        public uint RequestedChannelCount;
        [FieldOffset(392)]
        public uint AllocatedChannelCount;
        [FieldOffset(396)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] AllocatedChannels;
        [FieldOffset(432)]
        public IntPtr ChannelAdapter;
        [FieldOffset(440)]
        public byte NeedsMapRegisters;
        [FieldOffset(441)]
        public byte MasterDevice;
        [FieldOffset(442)]
        public byte ScatterGather;
        [FieldOffset(443)]
        public byte AutoInitialize;
        [FieldOffset(444)]
        public byte IgnoreCount;
        [FieldOffset(445)]
        public byte CacheCoherent;
        [FieldOffset(448)]
        public byte Dma32BitAddresses;
        [FieldOffset(449)]
        public byte Dma64BitAddresses;
        [FieldOffset(448)]
        public uint DmaAddressWidth;
        [FieldOffset(452)]
        public uint DmaPortWidth;
        [FieldOffset(456)]
        public _LARGE_INTEGER DeviceAddress;
        [FieldOffset(464)]
        public _LIST_ENTRY AdapterList;
        [FieldOffset(480)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(512)]
        public IntPtr DomainPointer;
        [FieldOffset(520)]
        public uint TranslationType;
        [FieldOffset(524)]
        public byte AdapterInUse;
        [FieldOffset(528)]
        public IntPtr DeviceObject;
        [FieldOffset(536)]
        public IntPtr DeviceId;
        [FieldOffset(544)]
        public IntPtr IommuDevice;
        [FieldOffset(552)]
        public IntPtr ScatterGatherMdl;
        [FieldOffset(560)]
        public IntPtr LowMemoryLogicalAddressToken;
        [FieldOffset(568)]
        public ulong LowMemoryLogicalAddressQueueLock;
        [FieldOffset(576)]
        public _LIST_ENTRY LowMemoryLogicalAddressQueue;
        [FieldOffset(592)]
        public byte LowMemoryLogicalAddressQueueInUse;
        [FieldOffset(600)]
        public _HALP_EMERGENCY_LA_QUEUE_ENTRY LowMemoryLogicalAddressQueueEntry;
        [FieldOffset(624)]
        public uint AllocationState;
        [FieldOffset(628)]
        public uint ScatterGatherBufferLength;
        [FieldOffset(632)]
        public _SCATTER_GATHER_LIST ScatterGatherBuffer;
    }
}