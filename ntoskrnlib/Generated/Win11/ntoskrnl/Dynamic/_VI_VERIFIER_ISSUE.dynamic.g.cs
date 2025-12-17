using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_VERIFIER_ISSUE")]
    public sealed class _VI_VERIFIER_ISSUE : DynamicStructure
    {
        public ulong IssueType { get; }
        public IntPtr Address { get; }
        public ulong[] Parameters { get; }

        public _VI_VERIFIER_ISSUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_VERIFIER_ISSUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_VERIFIER_ISSUE.IssueType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_VERIFIER_ISSUE.Address),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_VERIFIER_ISSUE.Parameters),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_VI_VERIFIER_ISSUE>((mem, ptr) => new _VI_VERIFIER_ISSUE(mem, ptr), offsets);
        }
    }
}