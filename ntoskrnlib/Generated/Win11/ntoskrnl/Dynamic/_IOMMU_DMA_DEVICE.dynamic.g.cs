using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DEVICE")]
    public sealed class _IOMMU_DMA_DEVICE : DynamicStructure
    {
        public IntPtr DeviceId { get; }
        public IntPtr DeviceObject { get; }
        public int DeviceState { get; }
        public IntPtr DomainOwner { get; }
        public _unnamed_tag_ Hypervisor { get; }
        public _unnamed_tag_ Native { get; }
        public IntPtr InterfaceCallbackRecord { get; }
        public byte DpptException { get; }
        public IntPtr SvmDevice { get; }
        public IntPtr FaultHandler { get; }
        public IntPtr FaultContext { get; }
        public _FAULT_INFORMATION FaultInfo { get; }
        public _KDPC FaultDpc { get; }
        public _WORK_QUEUE_ITEM FaultWorkItem { get; }
        public byte PasidFaultsSuppressed { get; }
        public byte PasidTaggedDmaEnabled { get; }
        public byte DefaultPasidEnabled { get; }
        public _IOMMU_BUS_INTERFACE IommuInterface { get; }
        public _LIST_ENTRY PasidDevicesList { get; }
        public _EX_PUSH_LOCK PasidDevicesListLock { get; }
        public _IOMMU_SVM_CAPABILITIES SvmCapControl { get; }
        public uint CreationStateInitial { get; }
        public uint CreationStateCurrent { get; }
        public _LIST_ENTRY DomainDmaDeviceEntry { get; }

        public _IOMMU_DMA_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_DEVICE.DeviceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DeviceState),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DomainOwner),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.Hypervisor),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.Native),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.InterfaceCallbackRecord),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DpptException),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.SvmDevice),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.FaultHandler),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.FaultContext),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.FaultInfo),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.FaultDpc),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.FaultWorkItem),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.PasidFaultsSuppressed),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.PasidTaggedDmaEnabled),
                    new ulong[]
                    {
                        273UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DefaultPasidEnabled),
                    new ulong[]
                    {
                        274UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.IommuInterface),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.PasidDevicesList),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.PasidDevicesListLock),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.SvmCapControl),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.CreationStateInitial),
                    new ulong[]
                    {
                        388UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.CreationStateCurrent),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DEVICE.DomainDmaDeviceEntry),
                    new ulong[]
                    {
                        400UL
                    }
                }
            };
            Register<_IOMMU_DMA_DEVICE>((mem, ptr) => new _IOMMU_DMA_DEVICE(mem, ptr), offsets);
        }
    }
}