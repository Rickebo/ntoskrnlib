using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_CLIENT_SECURITY_CONTEXT")]
    public sealed class _PS_CLIENT_SECURITY_CONTEXT : DynamicStructure
    {
        public ulong ImpersonationData { get; }
        public IntPtr ImpersonationToken { get; }
        public ulong ImpersonationLevel { get; }
        public ulong EffectiveOnly { get; }

        public _PS_CLIENT_SECURITY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_CLIENT_SECURITY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_CLIENT_SECURITY_CONTEXT.ImpersonationData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_CLIENT_SECURITY_CONTEXT.ImpersonationToken),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_CLIENT_SECURITY_CONTEXT.ImpersonationLevel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_CLIENT_SECURITY_CONTEXT.EffectiveOnly),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_CLIENT_SECURITY_CONTEXT>((mem, ptr) => new _PS_CLIENT_SECURITY_CONTEXT(mem, ptr), offsets);
        }
    }
}