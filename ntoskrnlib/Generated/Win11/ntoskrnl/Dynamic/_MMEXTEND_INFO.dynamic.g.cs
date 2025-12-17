using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMEXTEND_INFO")]
    public sealed class _MMEXTEND_INFO : DynamicStructure
    {
        public ulong CommittedSize { get; }
        public uint ReferenceCount { get; }

        public _MMEXTEND_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMEXTEND_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMEXTEND_INFO.CommittedSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMEXTEND_INFO.ReferenceCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MMEXTEND_INFO>((mem, ptr) => new _MMEXTEND_INFO(mem, ptr), offsets);
        }
    }
}