using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_INFO")]
    public sealed class _POP_FX_PERF_INFO : DynamicStructure
    {
        public IntPtr Component { get; }
        public _KEVENT CompletedEvent { get; }
        public IntPtr ComponentPerfState { get; }
        public _POP_FX_PERF_FLAGS Flags { get; }
        public IntPtr LastChange { get; }
        public uint LastChangeCount { get; }
        public ulong LastChangeStamp { get; }
        public byte LastChangeNominal { get; }
        public byte PepRegistered { get; }
        public byte QueryOnIdleStates { get; }
        public IntPtr RequestDriverContext { get; }
        public _POP_FX_WORK_ORDER WorkOrder { get; }
        public uint SetsCount { get; }
        public IntPtr Sets { get; }

        public _POP_FX_PERF_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_PERF_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_PERF_INFO.Component),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.CompletedEvent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.ComponentPerfState),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.LastChange),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.LastChangeCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.LastChangeStamp),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.LastChangeNominal),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.PepRegistered),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.QueryOnIdleStates),
                    new ulong[]
                    {
                        74UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.RequestDriverContext),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.WorkOrder),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.SetsCount),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_INFO.Sets),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_POP_FX_PERF_INFO>((mem, ptr) => new _POP_FX_PERF_INFO(mem, ptr), offsets);
        }
    }
}