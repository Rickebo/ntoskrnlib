using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_VALUE")]
    public sealed class _CM_KEY_VALUE : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort NameLength { get; }
        public uint DataLength { get; }
        public uint Data { get; }
        public uint Type { get; }
        public ushort Flags { get; }
        public ushort Spare { get; }
        public short[] Name { get; }

        public _CM_KEY_VALUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_VALUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_VALUE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.NameLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.DataLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.Data),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.Type),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.Spare),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_CM_KEY_VALUE.Name),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_CM_KEY_VALUE>((mem, ptr) => new _CM_KEY_VALUE(mem, ptr), offsets);
        }
    }
}