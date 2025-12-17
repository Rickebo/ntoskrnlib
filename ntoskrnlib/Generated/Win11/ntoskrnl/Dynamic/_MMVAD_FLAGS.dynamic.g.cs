using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMVAD_FLAGS")]
    public sealed class _MMVAD_FLAGS : DynamicStructure
    {
        public uint Lock { get; }
        public uint LockContended { get; }
        public uint DeleteInProgress { get; }
        public uint NoChange { get; }
        public uint VadType { get; }
        public uint Protection { get; }
        public uint PreferredNode { get; }
        public uint PageSize { get; }
        public uint PrivateMemory { get; }
        public uint EntireField { get; }

        public _MMVAD_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMVAD_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMVAD_FLAGS.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.LockContended),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.DeleteInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.NoChange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.VadType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.PreferredNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.PageSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.PrivateMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMVAD_FLAGS>((mem, ptr) => new _MMVAD_FLAGS(mem, ptr), offsets);
        }
    }
}