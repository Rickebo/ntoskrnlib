using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ADAPTER_OBJECT")]
    public sealed class _ADAPTER_OBJECT : DynamicStructure
    {
        public _HALP_DMA_ADAPTER_OBJECT AdapterObject { get; }
        public IntPtr MasterAdapter { get; }
        public _LIST_ENTRY WaitQueueEntry { get; }
        public _KDEVICE_QUEUE ChannelWaitQueue { get; }
        public ulong ResourceWaitLock { get; }
        public _LIST_ENTRY ResourceWaitQueue { get; }
        public _LIST_ENTRY ChannelResourceWaitQueue { get; }
        public byte ResourceQueueBusy { get; }
        public uint MapRegistersPerChannel { get; }
        public IntPtr MapRegisterBase { get; }
        public uint NumberOfMapRegisters { get; }
        public uint MaxTransferLength { get; }
        public byte[] CrashDumpRegisterBase { get; }
        public uint[] NumberOfCrashDumpRegisters { get; }
        public uint[] CrashDumpRegisterRefCount { get; }
        public _LIST_ENTRY AdapterCrashDumpList { get; }
        public IntPtr MapRegisterMdl { get; }
        public ulong MapRegisterMdlLock { get; }
        public _EX_PUSH_LOCK ExpiredLock { get; }
        public IntPtr AllocationHandle { get; }
        public IntPtr VirtualAddress { get; }
        public byte IsAllocationMdlBased { get; }
        public byte NoLocalPool { get; }
        public byte ExpiredFlag { get; }
        public IntPtr CurrentWcb { get; }
        public IntPtr CurrentTransferContext { get; }
        public IntPtr DmaController { get; }
        public uint Controller { get; }
        public uint ChannelNumber { get; }
        public uint RequestLine { get; }
        public uint RequestedChannelCount { get; }
        public uint AllocatedChannelCount { get; }
        public uint[] AllocatedChannels { get; }
        public IntPtr ChannelAdapter { get; }
        public byte NeedsMapRegisters { get; }
        public byte MasterDevice { get; }
        public byte ScatterGather { get; }
        public byte AutoInitialize { get; }
        public byte IgnoreCount { get; }
        public byte CacheCoherent { get; }
        public byte Dma32BitAddresses { get; }
        public byte Dma64BitAddresses { get; }
        public uint DmaAddressWidth { get; }
        public uint DmaPortWidth { get; }
        public _LARGE_INTEGER DeviceAddress { get; }
        public _LIST_ENTRY AdapterList { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr DomainPointer { get; }
        public uint TranslationType { get; }
        public byte AdapterInUse { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr DeviceId { get; }
        public IntPtr IommuDevice { get; }
        public IntPtr ScatterGatherMdl { get; }
        public IntPtr LowMemoryLogicalAddressToken { get; }
        public ulong LowMemoryLogicalAddressQueueLock { get; }
        public _LIST_ENTRY LowMemoryLogicalAddressQueue { get; }
        public byte LowMemoryLogicalAddressQueueInUse { get; }
        public _HALP_EMERGENCY_LA_QUEUE_ENTRY LowMemoryLogicalAddressQueueEntry { get; }
        public uint AllocationState { get; }
        public uint ScatterGatherBufferLength { get; }
        public _SCATTER_GATHER_LIST ScatterGatherBuffer { get; }

        public _ADAPTER_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ADAPTER_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ADAPTER_OBJECT.AdapterObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MasterAdapter),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.WaitQueueEntry),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ChannelWaitQueue),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ResourceWaitLock),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ResourceWaitQueue),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ChannelResourceWaitQueue),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ResourceQueueBusy),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MapRegistersPerChannel),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MapRegisterBase),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.NumberOfMapRegisters),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MaxTransferLength),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.CrashDumpRegisterBase),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.NumberOfCrashDumpRegisters),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.CrashDumpRegisterRefCount),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AdapterCrashDumpList),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MapRegisterMdl),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MapRegisterMdlLock),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ExpiredLock),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AllocationHandle),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.VirtualAddress),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.IsAllocationMdlBased),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.NoLocalPool),
                    new ulong[]
                    {
                        345UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ExpiredFlag),
                    new ulong[]
                    {
                        346UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.CurrentWcb),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.CurrentTransferContext),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DmaController),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.Controller),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ChannelNumber),
                    new ulong[]
                    {
                        380UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.RequestLine),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.RequestedChannelCount),
                    new ulong[]
                    {
                        388UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AllocatedChannelCount),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AllocatedChannels),
                    new ulong[]
                    {
                        396UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ChannelAdapter),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.NeedsMapRegisters),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.MasterDevice),
                    new ulong[]
                    {
                        441UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ScatterGather),
                    new ulong[]
                    {
                        442UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AutoInitialize),
                    new ulong[]
                    {
                        443UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.IgnoreCount),
                    new ulong[]
                    {
                        444UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.CacheCoherent),
                    new ulong[]
                    {
                        445UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.Dma32BitAddresses),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.Dma64BitAddresses),
                    new ulong[]
                    {
                        449UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DmaAddressWidth),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DmaPortWidth),
                    new ulong[]
                    {
                        452UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DeviceAddress),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AdapterList),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.WorkItem),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DomainPointer),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.TranslationType),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AdapterInUse),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DeviceObject),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.DeviceId),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.IommuDevice),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ScatterGatherMdl),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.LowMemoryLogicalAddressToken),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.LowMemoryLogicalAddressQueueLock),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.LowMemoryLogicalAddressQueue),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.LowMemoryLogicalAddressQueueInUse),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.LowMemoryLogicalAddressQueueEntry),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.AllocationState),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ScatterGatherBufferLength),
                    new ulong[]
                    {
                        628UL
                    }
                },
                {
                    nameof(_ADAPTER_OBJECT.ScatterGatherBuffer),
                    new ulong[]
                    {
                        632UL
                    }
                }
            };
            Register<_ADAPTER_OBJECT>((mem, ptr) => new _ADAPTER_OBJECT(mem, ptr), offsets);
        }
    }
}