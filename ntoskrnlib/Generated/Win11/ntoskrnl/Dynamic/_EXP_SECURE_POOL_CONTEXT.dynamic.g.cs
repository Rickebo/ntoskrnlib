using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXP_SECURE_POOL_CONTEXT")]
    public sealed class _EXP_SECURE_POOL_CONTEXT : DynamicStructure
    {
        public _EXP_POOL_CONTEXT_HEADER Header { get; }
        public IntPtr Handle { get; }

        public _EXP_SECURE_POOL_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXP_SECURE_POOL_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXP_SECURE_POOL_CONTEXT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXP_SECURE_POOL_CONTEXT.Handle),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXP_SECURE_POOL_CONTEXT>((mem, ptr) => new _EXP_SECURE_POOL_CONTEXT(mem, ptr), offsets);
        }
    }
}