using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTLP_HEAP_COMMIT_LIMIT_DATA")]
    public sealed class _RTLP_HEAP_COMMIT_LIMIT_DATA : DynamicStructure
    {
        public ulong CommitLimitBytes { get; }
        public ulong CommitLimitFailureCode { get; }

        public _RTLP_HEAP_COMMIT_LIMIT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HEAP_COMMIT_LIMIT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HEAP_COMMIT_LIMIT_DATA.CommitLimitBytes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HEAP_COMMIT_LIMIT_DATA.CommitLimitFailureCode),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTLP_HEAP_COMMIT_LIMIT_DATA>((mem, ptr) => new _RTLP_HEAP_COMMIT_LIMIT_DATA(mem, ptr), offsets);
        }
    }
}