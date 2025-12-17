using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IMAGE_DATA_DIRECTORY")]
    public sealed class _IMAGE_DATA_DIRECTORY : DynamicStructure
    {
        public uint VirtualAddress { get; }
        public uint Size { get; }

        public _IMAGE_DATA_DIRECTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_DATA_DIRECTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_DATA_DIRECTORY.VirtualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_DATA_DIRECTORY.Size),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IMAGE_DATA_DIRECTORY>((mem, ptr) => new _IMAGE_DATA_DIRECTORY(mem, ptr), offsets);
        }
    }
}