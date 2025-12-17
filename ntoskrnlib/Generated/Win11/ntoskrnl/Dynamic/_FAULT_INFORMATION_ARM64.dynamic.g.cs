using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_ARM64")]
    public sealed class _FAULT_INFORMATION_ARM64 : DynamicStructure
    {
        public IntPtr DomainHandle { get; }
        public IntPtr FaultAddress { get; }
        public IntPtr PhysicalDeviceObject { get; }
        public uint InputMappingId { get; }
        public _FAULT_INFORMATION_ARM64_FLAGS Flags { get; }
        public uint Type { get; }
        public ulong IommuBaseAddress { get; }

        public _FAULT_INFORMATION_ARM64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAULT_INFORMATION_ARM64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAULT_INFORMATION_ARM64.DomainHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.FaultAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.PhysicalDeviceObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.InputMappingId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.Type),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64.IommuBaseAddress),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_FAULT_INFORMATION_ARM64>((mem, ptr) => new _FAULT_INFORMATION_ARM64(mem, ptr), offsets);
        }
    }
}