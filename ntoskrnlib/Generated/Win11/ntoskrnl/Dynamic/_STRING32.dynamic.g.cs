using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STRING32")]
    public sealed class _STRING32 : DynamicStructure
    {
        public ushort Length { get; }
        public ushort MaximumLength { get; }
        public uint Buffer { get; }

        public _STRING32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STRING32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STRING32.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STRING32.MaximumLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_STRING32.Buffer),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_STRING32>((mem, ptr) => new _STRING32(mem, ptr), offsets);
        }
    }
}