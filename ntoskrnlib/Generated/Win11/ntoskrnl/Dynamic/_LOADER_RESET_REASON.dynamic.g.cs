using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_RESET_REASON")]
    public sealed class _LOADER_RESET_REASON : DynamicStructure
    {
        public byte Supplied { get; }
        public _unnamed_tag_ Basic { get; }
        public uint[] AdditionalInfo { get; }

        public _LOADER_RESET_REASON(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_RESET_REASON()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_RESET_REASON.Supplied),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_RESET_REASON.Basic),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_RESET_REASON.AdditionalInfo),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_LOADER_RESET_REASON>((mem, ptr) => new _LOADER_RESET_REASON(mem, ptr), offsets);
        }
    }
}