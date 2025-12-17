using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMSI_PROCESS_TUPLE")]
    public sealed class _CMSI_PROCESS_TUPLE : DynamicStructure
    {
        public IntPtr ProcessHandle { get; }
        public IntPtr ProcessReference { get; }
        public _CMSI_RW_LOCK WorkingSetLock { get; }
        public ulong LockedPageCharges { get; }
        public ulong WorkingSetMinimum { get; }
        public ulong WorkingSetMaximum { get; }

        public _CMSI_PROCESS_TUPLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMSI_PROCESS_TUPLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMSI_PROCESS_TUPLE.ProcessHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CMSI_PROCESS_TUPLE.ProcessReference),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CMSI_PROCESS_TUPLE.WorkingSetLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CMSI_PROCESS_TUPLE.LockedPageCharges),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CMSI_PROCESS_TUPLE.WorkingSetMinimum),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CMSI_PROCESS_TUPLE.WorkingSetMaximum),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_CMSI_PROCESS_TUPLE>((mem, ptr) => new _CMSI_PROCESS_TUPLE(mem, ptr), offsets);
        }
    }
}