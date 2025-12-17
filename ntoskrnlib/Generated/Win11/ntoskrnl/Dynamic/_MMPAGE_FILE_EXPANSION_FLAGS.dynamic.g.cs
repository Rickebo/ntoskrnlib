using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPAGE_FILE_EXPANSION_FLAGS")]
    public sealed class _MMPAGE_FILE_EXPANSION_FLAGS : DynamicStructure
    {
        public byte PageFileNumber { get; }
        public byte Spare1 { get; }
        public byte Spare2 { get; }
        public byte IgnoreCurrentCommit { get; }
        public byte IncreaseMinimumSize { get; }
        public byte AttemptForCantExtend { get; }
        public byte UnusedSegmentDeletion { get; }
        public byte PageFileContract { get; }
        public byte NoWait { get; }
        public byte BeingProcessed { get; }
        public byte Spare3 { get; }

        public _MMPAGE_FILE_EXPANSION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPAGE_FILE_EXPANSION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.PageFileNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.Spare1),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.Spare2),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.IgnoreCurrentCommit),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.IncreaseMinimumSize),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.AttemptForCantExtend),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.UnusedSegmentDeletion),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.PageFileContract),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.NoWait),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.BeingProcessed),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION_FLAGS.Spare3),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_MMPAGE_FILE_EXPANSION_FLAGS>((mem, ptr) => new _MMPAGE_FILE_EXPANSION_FLAGS(mem, ptr), offsets);
        }
    }
}