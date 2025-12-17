using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ACCESS_REASONS")]
    public sealed class _ACCESS_REASONS : DynamicStructure
    {
        public uint[] Data { get; }

        public _ACCESS_REASONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACCESS_REASONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACCESS_REASONS.Data),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ACCESS_REASONS>((mem, ptr) => new _ACCESS_REASONS(mem, ptr), offsets);
        }
    }
}