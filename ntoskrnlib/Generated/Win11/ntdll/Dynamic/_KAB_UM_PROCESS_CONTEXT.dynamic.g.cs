using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KAB_UM_PROCESS_CONTEXT")]
    public sealed class _KAB_UM_PROCESS_CONTEXT : DynamicStructure
    {
        public IntPtr Trees { get; }
        public uint TreeCount { get; }

        public _KAB_UM_PROCESS_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KAB_UM_PROCESS_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KAB_UM_PROCESS_CONTEXT.Trees),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KAB_UM_PROCESS_CONTEXT.TreeCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KAB_UM_PROCESS_CONTEXT>((mem, ptr) => new _KAB_UM_PROCESS_CONTEXT(mem, ptr), offsets);
        }
    }
}