using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_ARM64_FLAGS")]
    public sealed class _FAULT_INFORMATION_ARM64_FLAGS : DynamicStructure
    {
        public uint WriteNotRead { get; }
        public uint InstructionNotData { get; }
        public uint Privileged { get; }
        public uint FaultAddressValid { get; }
        public uint Reserved { get; }

        public _FAULT_INFORMATION_ARM64_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAULT_INFORMATION_ARM64_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAULT_INFORMATION_ARM64_FLAGS.WriteNotRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64_FLAGS.InstructionNotData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64_FLAGS.Privileged),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64_FLAGS.FaultAddressValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION_ARM64_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_FAULT_INFORMATION_ARM64_FLAGS>((mem, ptr) => new _FAULT_INFORMATION_ARM64_FLAGS(mem, ptr), offsets);
        }
    }
}