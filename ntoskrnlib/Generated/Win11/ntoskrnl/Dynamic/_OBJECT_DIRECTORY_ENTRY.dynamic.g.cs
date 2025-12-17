using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_DIRECTORY_ENTRY")]
    public sealed class _OBJECT_DIRECTORY_ENTRY : DynamicStructure
    {
        public IntPtr ChainLink { get; }
        public IntPtr Object { get; }
        public uint HashValue { get; }

        public _OBJECT_DIRECTORY_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_DIRECTORY_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_DIRECTORY_ENTRY.ChainLink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY_ENTRY.Object),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY_ENTRY.HashValue),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_OBJECT_DIRECTORY_ENTRY>((mem, ptr) => new _OBJECT_DIRECTORY_ENTRY(mem, ptr), offsets);
        }
    }
}