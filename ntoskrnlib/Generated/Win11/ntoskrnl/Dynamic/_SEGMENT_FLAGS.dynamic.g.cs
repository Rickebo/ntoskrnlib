using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEGMENT_FLAGS")]
    public sealed class _SEGMENT_FLAGS : DynamicStructure
    {
        public ushort TotalNumberOfPtes4132 { get; }
        public ushort LargePages { get; }
        public ushort DebugSymbolsLoaded { get; }
        public ushort WriteCombined { get; }
        public ushort NoCache { get; }
        public ushort ForceCollision { get; }
        public ushort Binary32 { get; }
        public ushort Short0 { get; }
        public byte DefaultProtectionMask { get; }
        public byte ContainsDebug { get; }
        public byte Spare { get; }
        public byte UChar1 { get; }
        public _MI_SEGMENT_SIGNATURE_FLAGS Signature { get; }

        public _SEGMENT_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEGMENT_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEGMENT_FLAGS.TotalNumberOfPtes4132),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.LargePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.DebugSymbolsLoaded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.WriteCombined),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.NoCache),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.ForceCollision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.Binary32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.Short0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.DefaultProtectionMask),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.ContainsDebug),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.Spare),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.UChar1),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SEGMENT_FLAGS.Signature),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_SEGMENT_FLAGS>((mem, ptr) => new _SEGMENT_FLAGS(mem, ptr), offsets);
        }
    }
}