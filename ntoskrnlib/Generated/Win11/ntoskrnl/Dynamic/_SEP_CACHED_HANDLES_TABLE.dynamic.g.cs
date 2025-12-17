using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_TABLE")]
    public sealed class _SEP_CACHED_HANDLES_TABLE : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public IntPtr HashTable { get; }

        public _SEP_CACHED_HANDLES_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_CACHED_HANDLES_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_CACHED_HANDLES_TABLE.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_TABLE.HashTable),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_SEP_CACHED_HANDLES_TABLE>((mem, ptr) => new _SEP_CACHED_HANDLES_TABLE(mem, ptr), offsets);
        }
    }
}