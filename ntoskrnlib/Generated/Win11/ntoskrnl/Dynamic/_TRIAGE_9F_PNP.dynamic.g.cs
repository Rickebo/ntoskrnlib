using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_9F_PNP")]
    public sealed class _TRIAGE_9F_PNP : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Revision { get; }
        public IntPtr CompletionQueue { get; }
        public IntPtr DelayedWorkQueue { get; }
        public IntPtr DelayedIoWorkQueue { get; }
        public IntPtr DeviceNode { get; }

        public _TRIAGE_9F_PNP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_9F_PNP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_9F_PNP.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_PNP.Revision),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_PNP.CompletionQueue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_PNP.DelayedWorkQueue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_PNP.DelayedIoWorkQueue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_PNP.DeviceNode),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_TRIAGE_9F_PNP>((mem, ptr) => new _TRIAGE_9F_PNP(mem, ptr), offsets);
        }
    }
}