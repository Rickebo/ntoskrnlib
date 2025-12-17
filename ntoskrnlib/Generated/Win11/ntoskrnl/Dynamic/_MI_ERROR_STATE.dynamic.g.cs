using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ERROR_STATE")]
    public sealed class _MI_ERROR_STATE : DynamicStructure
    {
        public _MI_BAD_MEMORY_EVENT_ENTRY BadMemoryEventEntry { get; }
        public _MI_PROBE_RAISE_TRACKER ProbeRaises { get; }
        public _MI_FORCED_COMMITS ForcedCommits { get; }
        public uint PrePhase0BugCheckParameter { get; }
        public uint WsleFailures { get; }
        public byte PendingBadPages { get; }
        public byte FatalGraphicsFailures { get; }
        public byte BadPagesInsertSignalState { get; }
        public uint PageHashErrorBehavior { get; }
        public uint PageHashReadErrors { get; }
        public uint PageHashStandbyErrors { get; }
        public uint PageHashTransferErrors { get; }
        public uint PageHashAllocationErrors { get; }
        public ulong FailedHashPageFrameIndex { get; }
        public uint CheckZeroCount { get; }
        public uint ZeroedPageSingleBitErrorsDetected { get; }
        public uint BadPagesDetected { get; }
        public uint BadPagesInserted { get; }
        public _WORK_QUEUE_ITEM BadPageInsertWorkItem { get; }
        public uint ScrubPasses { get; }
        public uint ScrubBadPagesFound { get; }
        public uint UserViewFailures { get; }
        public uint UserViewCollisionFailures { get; }
        public uint UserAllocateFailures { get; }
        public uint UserAllocateCollisionFailures { get; }
        public _MI_RESAVAIL_FAILURES ResavailFailures { get; }
        public uint BadPhysicalMapsEarly { get; }
        public uint BadPhysicalMaps { get; }

        public _MI_ERROR_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ERROR_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ERROR_STATE.BadMemoryEventEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ProbeRaises),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ForcedCommits),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PrePhase0BugCheckParameter),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.WsleFailures),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PendingBadPages),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.FatalGraphicsFailures),
                    new ulong[]
                    {
                        137UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPagesInsertSignalState),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PageHashErrorBehavior),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PageHashReadErrors),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PageHashStandbyErrors),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PageHashTransferErrors),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.PageHashAllocationErrors),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.FailedHashPageFrameIndex),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.CheckZeroCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ZeroedPageSingleBitErrorsDetected),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPagesDetected),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPagesInserted),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPageInsertWorkItem),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ScrubPasses),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ScrubBadPagesFound),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.UserViewFailures),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.UserViewCollisionFailures),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.UserAllocateFailures),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.UserAllocateCollisionFailures),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.ResavailFailures),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPhysicalMapsEarly),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_MI_ERROR_STATE.BadPhysicalMaps),
                    new ulong[]
                    {
                        252UL
                    }
                }
            };
            Register<_MI_ERROR_STATE>((mem, ptr) => new _MI_ERROR_STATE(mem, ptr), offsets);
        }
    }
}