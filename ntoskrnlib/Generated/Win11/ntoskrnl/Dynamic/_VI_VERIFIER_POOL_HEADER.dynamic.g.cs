using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_VERIFIER_POOL_HEADER")]
    public sealed class _VI_VERIFIER_POOL_HEADER : DynamicStructure
    {
        public IntPtr VerifierPoolEntry { get; }

        public _VI_VERIFIER_POOL_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_VERIFIER_POOL_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_VERIFIER_POOL_HEADER.VerifierPoolEntry),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_VI_VERIFIER_POOL_HEADER>((mem, ptr) => new _VI_VERIFIER_POOL_HEADER(mem, ptr), offsets);
        }
    }
}