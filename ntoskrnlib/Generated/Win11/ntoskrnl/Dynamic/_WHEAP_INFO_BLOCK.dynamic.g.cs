using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_INFO_BLOCK")]
    public sealed class _WHEAP_INFO_BLOCK : DynamicStructure
    {
        public uint ErrorSourceCount { get; }
        public IntPtr ErrorSourceTable { get; }
        public IntPtr WorkQueue { get; }

        public _WHEAP_INFO_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_INFO_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_INFO_BLOCK.ErrorSourceCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_INFO_BLOCK.ErrorSourceTable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEAP_INFO_BLOCK.WorkQueue),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_WHEAP_INFO_BLOCK>((mem, ptr) => new _WHEAP_INFO_BLOCK(mem, ptr), offsets);
        }
    }
}