using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KMCE_RECOVERY_CONTEXT")]
    public sealed class _KMCE_RECOVERY_CONTEXT : DynamicStructure
    {
        public uint Flags { get; }
        public uint Reserved { get; }
        public ulong PhysicalAddress { get; }
        public IntPtr Record { get; }

        public _KMCE_RECOVERY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KMCE_RECOVERY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KMCE_RECOVERY_CONTEXT.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KMCE_RECOVERY_CONTEXT.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KMCE_RECOVERY_CONTEXT.PhysicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KMCE_RECOVERY_CONTEXT.Record),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KMCE_RECOVERY_CONTEXT>((mem, ptr) => new _KMCE_RECOVERY_CONTEXT(mem, ptr), offsets);
        }
    }
}