using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_DATA")]
    public sealed class _WNF_STATE_DATA : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public uint AllocatedSize { get; }
        public uint DataSize { get; }
        public uint ChangeStamp { get; }

        public _WNF_STATE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_STATE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_STATE_DATA.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_DATA.AllocatedSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WNF_STATE_DATA.DataSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_STATE_DATA.ChangeStamp),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_WNF_STATE_DATA>((mem, ptr) => new _WNF_STATE_DATA(mem, ptr), offsets);
        }
    }
}