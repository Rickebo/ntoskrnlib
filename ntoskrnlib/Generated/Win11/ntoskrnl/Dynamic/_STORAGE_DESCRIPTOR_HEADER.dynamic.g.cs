using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STORAGE_DESCRIPTOR_HEADER")]
    public sealed class _STORAGE_DESCRIPTOR_HEADER : DynamicStructure
    {
        public uint Version { get; }
        public uint Size { get; }

        public _STORAGE_DESCRIPTOR_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STORAGE_DESCRIPTOR_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STORAGE_DESCRIPTOR_HEADER.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_DESCRIPTOR_HEADER.Size),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_STORAGE_DESCRIPTOR_HEADER>((mem, ptr) => new _STORAGE_DESCRIPTOR_HEADER(mem, ptr), offsets);
        }
    }
}