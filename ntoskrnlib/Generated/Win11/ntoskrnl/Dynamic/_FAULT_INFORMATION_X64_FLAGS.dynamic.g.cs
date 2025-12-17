using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_X64_FLAGS")]
    public sealed class _FAULT_INFORMATION_X64_FLAGS : DynamicStructure
    {
        public uint FaultAddressValid { get; }
        public uint Reserved { get; }

        public _FAULT_INFORMATION_X64_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAULT_INFORMATION_X64_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAULT_INFORMATION_X64_FLAGS.FaultAddressValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_X64_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_FAULT_INFORMATION_X64_FLAGS>((mem, ptr) => new _FAULT_INFORMATION_X64_FLAGS(mem, ptr), offsets);
        }
    }
}