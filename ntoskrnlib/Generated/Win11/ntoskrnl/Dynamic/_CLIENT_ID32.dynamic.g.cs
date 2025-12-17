using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CLIENT_ID32")]
    public sealed class _CLIENT_ID32 : DynamicStructure
    {
        public uint UniqueProcess { get; }
        public uint UniqueThread { get; }

        public _CLIENT_ID32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CLIENT_ID32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CLIENT_ID32.UniqueProcess),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CLIENT_ID32.UniqueThread),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CLIENT_ID32>((mem, ptr) => new _CLIENT_ID32(mem, ptr), offsets);
        }
    }
}