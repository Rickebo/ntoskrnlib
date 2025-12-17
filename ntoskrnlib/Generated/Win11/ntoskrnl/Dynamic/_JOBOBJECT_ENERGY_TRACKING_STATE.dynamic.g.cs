using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_JOBOBJECT_ENERGY_TRACKING_STATE")]
    public sealed class _JOBOBJECT_ENERGY_TRACKING_STATE : DynamicStructure
    {
        public ulong Value { get; }
        public uint UpdateMask { get; }
        public uint DesiredState { get; }

        public _JOBOBJECT_ENERGY_TRACKING_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOBOBJECT_ENERGY_TRACKING_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_JOBOBJECT_ENERGY_TRACKING_STATE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_JOBOBJECT_ENERGY_TRACKING_STATE.UpdateMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_JOBOBJECT_ENERGY_TRACKING_STATE.DesiredState),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_JOBOBJECT_ENERGY_TRACKING_STATE>((mem, ptr) => new _JOBOBJECT_ENERGY_TRACKING_STATE(mem, ptr), offsets);
        }
    }
}