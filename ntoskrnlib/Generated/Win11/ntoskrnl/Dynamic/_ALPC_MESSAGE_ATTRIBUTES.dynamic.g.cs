using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_MESSAGE_ATTRIBUTES")]
    public sealed class _ALPC_MESSAGE_ATTRIBUTES : DynamicStructure
    {
        public uint AllocatedAttributes { get; }
        public uint ValidAttributes { get; }

        public _ALPC_MESSAGE_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_MESSAGE_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_MESSAGE_ATTRIBUTES.AllocatedAttributes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_MESSAGE_ATTRIBUTES.ValidAttributes),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ALPC_MESSAGE_ATTRIBUTES>((mem, ptr) => new _ALPC_MESSAGE_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}