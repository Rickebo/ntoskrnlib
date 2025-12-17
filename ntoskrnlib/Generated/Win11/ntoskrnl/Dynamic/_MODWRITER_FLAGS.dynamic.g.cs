using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MODWRITER_FLAGS")]
    public sealed class _MODWRITER_FLAGS : DynamicStructure
    {
        public uint KeepForever { get; }
        public uint Networked { get; }
        public uint IoPriority { get; }
        public uint PfBacked { get; }
        public uint ModifiedStoreWrite { get; }

        public _MODWRITER_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MODWRITER_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MODWRITER_FLAGS.KeepForever),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MODWRITER_FLAGS.Networked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MODWRITER_FLAGS.IoPriority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MODWRITER_FLAGS.PfBacked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MODWRITER_FLAGS.ModifiedStoreWrite),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MODWRITER_FLAGS>((mem, ptr) => new _MODWRITER_FLAGS(mem, ptr), offsets);
        }
    }
}