using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ECP_LIST")]
    public sealed class _ECP_LIST : DynamicStructure
    {
        public uint Signature { get; }
        public uint Flags { get; }
        public _LIST_ENTRY EcpList { get; }

        public _ECP_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ECP_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ECP_LIST.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ECP_LIST.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ECP_LIST.EcpList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ECP_LIST>((mem, ptr) => new _ECP_LIST(mem, ptr), offsets);
        }
    }
}