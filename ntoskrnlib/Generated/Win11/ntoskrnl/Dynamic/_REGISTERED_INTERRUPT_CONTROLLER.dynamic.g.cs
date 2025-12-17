using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_REGISTERED_INTERRUPT_CONTROLLER")]
    public sealed class _REGISTERED_INTERRUPT_CONTROLLER : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr InternalData { get; }
        public uint InternalDataSize { get; }
        public _INTERRUPT_FUNCTION_TABLE FunctionTable { get; }
        public uint KnownType { get; }
        public uint Capabilities { get; }
        public uint Flags { get; }
        public uint MaxPriority { get; }
        public uint UnitId { get; }
        public _LIST_ENTRY LinesHead { get; }
        public _LIST_ENTRY OutputLinesHead { get; }
        public int MinLine { get; }
        public int MaxLine { get; }
        public uint MaxClusterSize { get; }
        public uint MaxClusters { get; }
        public uint InterruptReplayDataSize { get; }
        public uint Problem { get; }
        public int ProblemStatus { get; }
        public IntPtr ProblemSourceFile { get; }
        public uint ProblemSourceLine { get; }
        public uint CustomProblem { get; }
        public int CustomProblemStatus { get; }
        public _UNICODE_STRING ResourceId { get; }
        public IntPtr PowerHandle { get; }

        public _REGISTERED_INTERRUPT_CONTROLLER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _REGISTERED_INTERRUPT_CONTROLLER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.InternalData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.InternalDataSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.FunctionTable),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.KnownType),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.Capabilities),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.Flags),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.MaxPriority),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.UnitId),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.LinesHead),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.OutputLinesHead),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.MinLine),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.MaxLine),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.MaxClusterSize),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.MaxClusters),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.InterruptReplayDataSize),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.Problem),
                    new ulong[]
                    {
                        316UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.ProblemStatus),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.ProblemSourceFile),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.ProblemSourceLine),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.CustomProblem),
                    new ulong[]
                    {
                        340UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.CustomProblemStatus),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.ResourceId),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_REGISTERED_INTERRUPT_CONTROLLER.PowerHandle),
                    new ulong[]
                    {
                        368UL
                    }
                }
            };
            Register<_REGISTERED_INTERRUPT_CONTROLLER>((mem, ptr) => new _REGISTERED_INTERRUPT_CONTROLLER(mem, ptr), offsets);
        }
    }
}