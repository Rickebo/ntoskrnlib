using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CLIENT_ID")]
    public sealed class _CLIENT_ID : DynamicStructure
    {
        public IntPtr UniqueProcess { get; }
        public IntPtr UniqueThread { get; }

        public _CLIENT_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CLIENT_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CLIENT_ID.UniqueProcess),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CLIENT_ID.UniqueThread),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CLIENT_ID>((mem, ptr) => new _CLIENT_ID(mem, ptr), offsets);
        }
    }
}