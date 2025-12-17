using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_SECTION_SYNC_OUTPUT")]
    public sealed class _FS_FILTER_SECTION_SYNC_OUTPUT : DynamicStructure
    {
        public uint StructureSize { get; }
        public uint SizeReturned { get; }
        public uint Flags { get; }
        public uint DesiredReadAlignment { get; }

        public _FS_FILTER_SECTION_SYNC_OUTPUT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FS_FILTER_SECTION_SYNC_OUTPUT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FS_FILTER_SECTION_SYNC_OUTPUT.StructureSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_SECTION_SYNC_OUTPUT.SizeReturned),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FS_FILTER_SECTION_SYNC_OUTPUT.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FS_FILTER_SECTION_SYNC_OUTPUT.DesiredReadAlignment),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_FS_FILTER_SECTION_SYNC_OUTPUT>((mem, ptr) => new _FS_FILTER_SECTION_SYNC_OUTPUT(mem, ptr), offsets);
        }
    }
}