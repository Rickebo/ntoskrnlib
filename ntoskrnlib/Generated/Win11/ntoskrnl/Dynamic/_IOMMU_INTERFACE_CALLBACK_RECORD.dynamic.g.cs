using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_CALLBACK_RECORD")]
    public sealed class _IOMMU_INTERFACE_CALLBACK_RECORD : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr CallbackRoutine { get; }
        public IntPtr CallbackContext { get; }
        public IntPtr DmaDevice { get; }
        public _IOMMU_INTERFACE_STATE_CHANGE LastReportedState { get; }

        public _IOMMU_INTERFACE_CALLBACK_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_INTERFACE_CALLBACK_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_INTERFACE_CALLBACK_RECORD.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_CALLBACK_RECORD.CallbackRoutine),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_CALLBACK_RECORD.CallbackContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_CALLBACK_RECORD.DmaDevice),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_CALLBACK_RECORD.LastReportedState),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_IOMMU_INTERFACE_CALLBACK_RECORD>((mem, ptr) => new _IOMMU_INTERFACE_CALLBACK_RECORD(mem, ptr), offsets);
        }
    }
}