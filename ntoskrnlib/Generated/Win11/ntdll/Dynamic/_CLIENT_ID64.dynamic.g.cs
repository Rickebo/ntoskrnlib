using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_CLIENT_ID64")]
    public sealed class _CLIENT_ID64 : DynamicStructure
    {
        public ulong UniqueProcess { get; }
        public ulong UniqueThread { get; }

        public _CLIENT_ID64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CLIENT_ID64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CLIENT_ID64.UniqueProcess),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CLIENT_ID64.UniqueThread),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CLIENT_ID64>((mem, ptr) => new _CLIENT_ID64(mem, ptr), offsets);
        }
    }
}