using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_SOURCE")]
    public sealed class _TOKEN_SOURCE : DynamicStructure
    {
        public sbyte[] SourceName { get; }
        public _LUID SourceIdentifier { get; }

        public _TOKEN_SOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_SOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_SOURCE.SourceName),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TOKEN_SOURCE.SourceIdentifier),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TOKEN_SOURCE>((mem, ptr) => new _TOKEN_SOURCE(mem, ptr), offsets);
        }
    }
}