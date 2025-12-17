using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CLONE_BLOCK_FLAGS")]
    public sealed class _MI_CLONE_BLOCK_FLAGS : DynamicStructure
    {
        public ulong CloneProtection { get; }
        public ulong ReducedCommitReferences { get; }
        public ulong ScpPage { get; }
        public ulong Spare { get; }
        public ulong LockBit { get; }
        public long EntireField { get; }

        public _MI_CLONE_BLOCK_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CLONE_BLOCK_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.CloneProtection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.ReducedCommitReferences),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.ScpPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.LockBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CLONE_BLOCK_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_CLONE_BLOCK_FLAGS>((mem, ptr) => new _MI_CLONE_BLOCK_FLAGS(mem, ptr), offsets);
        }
    }
}