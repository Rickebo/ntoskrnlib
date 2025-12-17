using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_NAME_STRUCT")]
    public sealed class _WNF_STATE_NAME_STRUCT : DynamicStructure
    {
        public ulong Version { get; }
        public ulong NameLifetime { get; }
        public ulong DataScope { get; }
        public ulong PermanentData { get; }
        public ulong Sequence { get; }

        public _WNF_STATE_NAME_STRUCT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_STATE_NAME_STRUCT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_STATE_NAME_STRUCT.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_STRUCT.NameLifetime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_STRUCT.DataScope),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_STRUCT.PermanentData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_STRUCT.Sequence),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WNF_STATE_NAME_STRUCT>((mem, ptr) => new _WNF_STATE_NAME_STRUCT(mem, ptr), offsets);
        }
    }
}