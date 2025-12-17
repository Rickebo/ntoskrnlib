using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_CONTROL")]
    public sealed class _TOKEN_CONTROL : DynamicStructure
    {
        public _LUID TokenId { get; }
        public _LUID AuthenticationId { get; }
        public _LUID ModifiedId { get; }
        public _TOKEN_SOURCE TokenSource { get; }

        public _TOKEN_CONTROL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_CONTROL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_CONTROL.TokenId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TOKEN_CONTROL.AuthenticationId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TOKEN_CONTROL.ModifiedId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TOKEN_CONTROL.TokenSource),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_TOKEN_CONTROL>((mem, ptr) => new _TOKEN_CONTROL(mem, ptr), offsets);
        }
    }
}