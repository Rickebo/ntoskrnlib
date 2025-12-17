using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_TOKEN_PRIVILEGES")]
    public sealed class _SEP_TOKEN_PRIVILEGES : DynamicStructure
    {
        public ulong Present { get; }
        public ulong Enabled { get; }
        public ulong EnabledByDefault { get; }

        public _SEP_TOKEN_PRIVILEGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_TOKEN_PRIVILEGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_TOKEN_PRIVILEGES.Present),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_PRIVILEGES.Enabled),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_PRIVILEGES.EnabledByDefault),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SEP_TOKEN_PRIVILEGES>((mem, ptr) => new _SEP_TOKEN_PRIVILEGES(mem, ptr), offsets);
        }
    }
}