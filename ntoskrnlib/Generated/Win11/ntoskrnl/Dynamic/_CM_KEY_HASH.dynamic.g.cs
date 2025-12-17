using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_HASH")]
    public sealed class _CM_KEY_HASH : DynamicStructure
    {
        public _CM_PATH_HASH ConvKey { get; }
        public IntPtr NextHash { get; }
        public IntPtr KeyHive { get; }
        public uint KeyCell { get; }

        public _CM_KEY_HASH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_HASH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_HASH.ConvKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_HASH.NextHash),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_HASH.KeyHive),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_HASH.KeyCell),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_CM_KEY_HASH>((mem, ptr) => new _CM_KEY_HASH(mem, ptr), offsets);
        }
    }
}