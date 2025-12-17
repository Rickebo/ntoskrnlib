using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PERFINFO_PPM_STATE_SELECTION")]
    public sealed class _PERFINFO_PPM_STATE_SELECTION : DynamicStructure
    {
        public uint SelectedState { get; }
        public uint VetoedStates { get; }
        public uint[] VetoReason { get; }

        public _PERFINFO_PPM_STATE_SELECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PERFINFO_PPM_STATE_SELECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PERFINFO_PPM_STATE_SELECTION.SelectedState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PERFINFO_PPM_STATE_SELECTION.VetoedStates),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PERFINFO_PPM_STATE_SELECTION.VetoReason),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PERFINFO_PPM_STATE_SELECTION>((mem, ptr) => new _PERFINFO_PPM_STATE_SELECTION(mem, ptr), offsets);
        }
    }
}