using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_NAME_HASH")]
    public sealed class _CM_NAME_HASH : DynamicStructure
    {
        public _CM_COMPONENT_HASH ConvKey { get; }
        public IntPtr NextHash { get; }
        public ushort NameLength { get; }
        public short[] Name { get; }

        public _CM_NAME_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_NAME_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_NAME_HASH.ConvKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_NAME_HASH.NextHash),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_NAME_HASH.NameLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_NAME_HASH.Name),
                    new ulong[]
                    {
                        18UL
                    }
                }
            };
            Register<_CM_NAME_HASH>((mem, ptr) => new _CM_NAME_HASH(mem, ptr), offsets);
        }
    }
}