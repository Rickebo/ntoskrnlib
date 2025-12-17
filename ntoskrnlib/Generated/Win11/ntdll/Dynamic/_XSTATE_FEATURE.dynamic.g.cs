using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_XSTATE_FEATURE")]
    public sealed class _XSTATE_FEATURE : DynamicStructure
    {
        public uint Offset { get; }
        public uint Size { get; }

        public _XSTATE_FEATURE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSTATE_FEATURE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSTATE_FEATURE.Offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSTATE_FEATURE.Size),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_XSTATE_FEATURE>((mem, ptr) => new _XSTATE_FEATURE(mem, ptr), offsets);
        }
    }
}