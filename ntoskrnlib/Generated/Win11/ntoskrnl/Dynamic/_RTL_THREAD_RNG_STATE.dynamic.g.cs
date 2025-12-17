using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_THREAD_RNG_STATE")]
    public sealed class _RTL_THREAD_RNG_STATE : DynamicStructure
    {
        public ulong[] State64 { get; }
        public uint[] State32 { get; }

        public _RTL_THREAD_RNG_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_THREAD_RNG_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_THREAD_RNG_STATE.State64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_THREAD_RNG_STATE.State32),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_THREAD_RNG_STATE>((mem, ptr) => new _RTL_THREAD_RNG_STATE(mem, ptr), offsets);
        }
    }
}