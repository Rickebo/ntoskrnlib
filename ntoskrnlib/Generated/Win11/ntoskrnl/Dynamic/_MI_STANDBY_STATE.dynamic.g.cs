using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_STANDBY_STATE")]
    public sealed class _MI_STANDBY_STATE : DynamicStructure
    {
        public ulong FirstDecayPage { get; }
        public _SLIST_HEADER PfnDecayFreeSList { get; }
        public int DecayPfnLock { get; }
        public _RTL_BITMAP DecayPfnsToBeFreed { get; }
        public uint[] DecayPfnsToBeFreedBuffer { get; }
        public _SLIST_HEADER PageHeatListSlist { get; }
        public int PageHeatListDisableAllocation { get; }
        public uint TransitionPagesMadeCold { get; }

        public _MI_STANDBY_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_STANDBY_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_STANDBY_STATE.FirstDecayPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.PfnDecayFreeSList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.DecayPfnLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.DecayPfnsToBeFreed),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.DecayPfnsToBeFreedBuffer),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.PageHeatListSlist),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.PageHeatListDisableAllocation),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_MI_STANDBY_STATE.TransitionPagesMadeCold),
                    new ulong[]
                    {
                        340UL
                    }
                }
            };
            Register<_MI_STANDBY_STATE>((mem, ptr) => new _MI_STANDBY_STATE(mem, ptr), offsets);
        }
    }
}