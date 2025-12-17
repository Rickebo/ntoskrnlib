using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_MAP")]
    public sealed class _WNF_SCOPE_MAP : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public IntPtr SystemScopeInstance { get; }
        public IntPtr MachineScopeInstance { get; }
        public IntPtr PhysicalMachineScopeInstance { get; }
        public byte[] ByDataScope { get; }

        public _WNF_SCOPE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SCOPE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_SCOPE_MAP.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_MAP.SystemScopeInstance),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_MAP.MachineScopeInstance),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_MAP.PhysicalMachineScopeInstance),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_MAP.ByDataScope),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_WNF_SCOPE_MAP>((mem, ptr) => new _WNF_SCOPE_MAP(mem, ptr), offsets);
        }
    }
}