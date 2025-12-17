using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PROCESSOR_IDLESTATE_POLICY")]
    public sealed class PROCESSOR_IDLESTATE_POLICY : DynamicStructure
    {
        public ushort Revision { get; }
        public _unnamed_tag_ Flags { get; }
        public uint PolicyCount { get; }
        public byte[] Policy { get; }

        public PROCESSOR_IDLESTATE_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PROCESSOR_IDLESTATE_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PROCESSOR_IDLESTATE_POLICY.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_POLICY.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_POLICY.PolicyCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_POLICY.Policy),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<PROCESSOR_IDLESTATE_POLICY>((mem, ptr) => new PROCESSOR_IDLESTATE_POLICY(mem, ptr), offsets);
        }
    }
}