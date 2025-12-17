using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VACB_LEVEL_REFERENCE")]
    public sealed class _VACB_LEVEL_REFERENCE : DynamicStructure
    {
        public int Reference { get; }
        public int SpecialReference { get; }

        public _VACB_LEVEL_REFERENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VACB_LEVEL_REFERENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VACB_LEVEL_REFERENCE.Reference),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VACB_LEVEL_REFERENCE.SpecialReference),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_VACB_LEVEL_REFERENCE>((mem, ptr) => new _VACB_LEVEL_REFERENCE(mem, ptr), offsets);
        }
    }
}