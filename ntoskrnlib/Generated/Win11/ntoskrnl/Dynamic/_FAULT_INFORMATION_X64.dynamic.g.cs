using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_X64")]
    public sealed class _FAULT_INFORMATION_X64 : DynamicStructure
    {
        public IntPtr DomainHandle { get; }
        public IntPtr FaultAddress { get; }
        public _FAULT_INFORMATION_X64_FLAGS Flags { get; }
        public uint Type { get; }
        public ulong IommuBaseAddress { get; }
        public uint PciSegment { get; }

        public _FAULT_INFORMATION_X64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAULT_INFORMATION_X64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAULT_INFORMATION_X64.DomainHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64.FaultAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64.Type),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64.IommuBaseAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64.PciSegment),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_FAULT_INFORMATION_X64>((mem, ptr) => new _FAULT_INFORMATION_X64(mem, ptr), offsets);
        }
    }
}