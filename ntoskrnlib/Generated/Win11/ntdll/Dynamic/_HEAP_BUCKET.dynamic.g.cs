using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_BUCKET")]
    public sealed class _HEAP_BUCKET : DynamicStructure
    {
        public ushort BlockUnits { get; }
        public byte SizeIndex { get; }
        public byte UseAffinity { get; }
        public byte DebugFlags { get; }
        public byte Flags { get; }

        public _HEAP_BUCKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_BUCKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_BUCKET.BlockUnits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET.SizeIndex),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET.UseAffinity),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET.DebugFlags),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET.Flags),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_HEAP_BUCKET>((mem, ptr) => new _HEAP_BUCKET(mem, ptr), offsets);
        }
    }
}