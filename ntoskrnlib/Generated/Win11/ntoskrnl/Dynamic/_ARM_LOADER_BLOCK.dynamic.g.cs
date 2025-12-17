using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARM_LOADER_BLOCK")]
    public sealed class _ARM_LOADER_BLOCK : DynamicStructure
    {
        public uint PlaceHolder { get; }

        public _ARM_LOADER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARM_LOADER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARM_LOADER_BLOCK.PlaceHolder),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARM_LOADER_BLOCK>((mem, ptr) => new _ARM_LOADER_BLOCK(mem, ptr), offsets);
        }
    }
}