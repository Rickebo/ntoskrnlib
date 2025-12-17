using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EXT_SET_PARAMETERS_V0")]
    public sealed class _EXT_SET_PARAMETERS_V0 : DynamicStructure
    {
        public uint Version { get; }
        public uint Reserved { get; }
        public long NoWakeTolerance { get; }

        public _EXT_SET_PARAMETERS_V0(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_SET_PARAMETERS_V0()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_SET_PARAMETERS_V0.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_SET_PARAMETERS_V0.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXT_SET_PARAMETERS_V0.NoWakeTolerance),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXT_SET_PARAMETERS_V0>((mem, ptr) => new _EXT_SET_PARAMETERS_V0(mem, ptr), offsets);
        }
    }
}