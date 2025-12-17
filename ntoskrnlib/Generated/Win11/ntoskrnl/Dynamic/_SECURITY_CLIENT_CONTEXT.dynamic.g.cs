using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECURITY_CLIENT_CONTEXT")]
    public sealed class _SECURITY_CLIENT_CONTEXT : DynamicStructure
    {
        public _SECURITY_QUALITY_OF_SERVICE SecurityQos { get; }
        public IntPtr ClientToken { get; }
        public byte DirectlyAccessClientToken { get; }
        public byte DirectAccessEffectiveOnly { get; }
        public byte ServerIsRemote { get; }
        public _TOKEN_CONTROL ClientTokenControl { get; }

        public _SECURITY_CLIENT_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECURITY_CLIENT_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.SecurityQos),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.ClientToken),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.DirectlyAccessClientToken),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.DirectAccessEffectiveOnly),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.ServerIsRemote),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_SECURITY_CLIENT_CONTEXT.ClientTokenControl),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_SECURITY_CLIENT_CONTEXT>((mem, ptr) => new _SECURITY_CLIENT_CONTEXT(mem, ptr), offsets);
        }
    }
}