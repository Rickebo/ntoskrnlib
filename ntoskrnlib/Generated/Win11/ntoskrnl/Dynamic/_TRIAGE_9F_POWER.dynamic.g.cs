using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_9F_POWER")]
    public sealed class _TRIAGE_9F_POWER : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Revision { get; }
        public IntPtr IrpList { get; }
        public IntPtr ThreadList { get; }
        public IntPtr DelayedWorkQueue { get; }
        public IntPtr DelayedIoWorkQueue { get; }

        public _TRIAGE_9F_POWER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_9F_POWER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_9F_POWER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_POWER.Revision),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_POWER.IrpList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_POWER.ThreadList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_POWER.DelayedWorkQueue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_POWER.DelayedIoWorkQueue),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_TRIAGE_9F_POWER>((mem, ptr) => new _TRIAGE_9F_POWER(mem, ptr), offsets);
        }
    }
}