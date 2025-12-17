using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPFNENTRY1")]
    public sealed class _MMPFNENTRY1 : DynamicStructure
    {
        public byte PageLocation { get; }
        public byte WriteInProgress { get; }
        public byte Modified { get; }
        public byte ReadInProgress { get; }
        public byte CacheAttribute { get; }

        public _MMPFNENTRY1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPFNENTRY1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPFNENTRY1.PageLocation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY1.WriteInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY1.Modified),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY1.ReadInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY1.CacheAttribute),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPFNENTRY1>((mem, ptr) => new _MMPFNENTRY1(mem, ptr), offsets);
        }
    }
}