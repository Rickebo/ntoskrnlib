using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_u")]
    public sealed class _u : DynamicStructure
    {
        public _CM_KEY_NODE KeyNode { get; }
        public _CM_KEY_VALUE KeyValue { get; }
        public _CM_KEY_SECURITY KeySecurity { get; }
        public _CM_KEY_INDEX KeyIndex { get; }
        public _CM_BIG_DATA ValueData { get; }
        public uint[] KeyList { get; }
        public short[] KeyString { get; }

        public _u(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _u()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_u.KeyNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.KeyValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.KeySecurity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.KeyIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.ValueData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.KeyList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_u.KeyString),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_u>((mem, ptr) => new _u(mem, ptr), offsets);
        }
    }
}