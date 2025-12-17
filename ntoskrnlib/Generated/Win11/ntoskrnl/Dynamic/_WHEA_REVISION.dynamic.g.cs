using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_REVISION")]
    public sealed class _WHEA_REVISION : DynamicStructure
    {
        public byte MinorRevision { get; }
        public byte MajorRevision { get; }
        public ushort AsUSHORT { get; }

        public _WHEA_REVISION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_REVISION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_REVISION.MinorRevision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_REVISION.MajorRevision),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_WHEA_REVISION.AsUSHORT),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_REVISION>((mem, ptr) => new _WHEA_REVISION(mem, ptr), offsets);
        }
    }
}