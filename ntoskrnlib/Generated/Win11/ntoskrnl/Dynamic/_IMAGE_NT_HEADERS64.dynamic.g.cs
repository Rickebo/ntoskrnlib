using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_NT_HEADERS64")]
    public sealed class _IMAGE_NT_HEADERS64 : DynamicStructure
    {
        public uint Signature { get; }
        public _IMAGE_FILE_HEADER FileHeader { get; }
        public _IMAGE_OPTIONAL_HEADER64 OptionalHeader { get; }

        public _IMAGE_NT_HEADERS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_NT_HEADERS64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_NT_HEADERS64.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_NT_HEADERS64.FileHeader),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_NT_HEADERS64.OptionalHeader),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IMAGE_NT_HEADERS64>((mem, ptr) => new _IMAGE_NT_HEADERS64(mem, ptr), offsets);
        }
    }
}