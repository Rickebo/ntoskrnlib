using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSECURE_FLAGS")]
    public sealed class _MMSECURE_FLAGS : DynamicStructure
    {
        public uint ReadOnly { get; }
        public uint ReadWrite { get; }
        public uint SecNoChange { get; }
        public uint NoDelete { get; }
        public uint RequiresPteReversal { get; }
        public uint ExclusiveSecure { get; }
        public uint UserModeOnly { get; }
        public uint NoInherit { get; }
        public uint CheckVad { get; }
        public uint Spare { get; }

        public _MMSECURE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSECURE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSECURE_FLAGS.ReadOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.ReadWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.SecNoChange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.NoDelete),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.RequiresPteReversal),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.ExclusiveSecure),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.UserModeOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.NoInherit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.CheckVad),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECURE_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMSECURE_FLAGS>((mem, ptr) => new _MMSECURE_FLAGS(mem, ptr), offsets);
        }
    }
}