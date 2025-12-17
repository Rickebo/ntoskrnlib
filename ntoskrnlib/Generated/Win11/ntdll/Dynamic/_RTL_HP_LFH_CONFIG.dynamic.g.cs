using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_HP_LFH_CONFIG")]
    public sealed class _RTL_HP_LFH_CONFIG : DynamicStructure
    {
        public ushort MaxBlockSize { get; }
        public ushort WitholdPageCrossingBlocks { get; }
        public uint AllFields { get; }

        public _RTL_HP_LFH_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HP_LFH_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HP_LFH_CONFIG.MaxBlockSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HP_LFH_CONFIG.WitholdPageCrossingBlocks),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_RTL_HP_LFH_CONFIG.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_HP_LFH_CONFIG>((mem, ptr) => new _RTL_HP_LFH_CONFIG(mem, ptr), offsets);
        }
    }
}