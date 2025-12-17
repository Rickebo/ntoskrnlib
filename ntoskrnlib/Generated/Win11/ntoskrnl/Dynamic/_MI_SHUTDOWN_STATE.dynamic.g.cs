using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SHUTDOWN_STATE")]
    public sealed class _MI_SHUTDOWN_STATE : DynamicStructure
    {
        public byte CrashDumpInitialized { get; }
        public byte ConnectedStandbyActive { get; }
        public byte ZeroPageFileAtShutdown { get; }
        public byte CacheConflictsAllowed { get; }
        public uint SystemShutdown { get; }
        public int ShutdownFlushInProgress { get; }
        public uint MirroringActive { get; }
        public _MI_RESUME_WORKITEM ResumeItem { get; }
        public IntPtr MirrorHoldsPfn { get; }
        public byte[] MirrorBitMaps { get; }
        public uint MirrorBitMapState { get; }
        public IntPtr CrashDumpPte { get; }

        public _MI_SHUTDOWN_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SHUTDOWN_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SHUTDOWN_STATE.CrashDumpInitialized),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.ConnectedStandbyActive),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.ZeroPageFileAtShutdown),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.CacheConflictsAllowed),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.SystemShutdown),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.ShutdownFlushInProgress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.MirroringActive),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.ResumeItem),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.MirrorHoldsPfn),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.MirrorBitMaps),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.MirrorBitMapState),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_SHUTDOWN_STATE.CrashDumpPte),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_MI_SHUTDOWN_STATE>((mem, ptr) => new _MI_SHUTDOWN_STATE(mem, ptr), offsets);
        }
    }
}