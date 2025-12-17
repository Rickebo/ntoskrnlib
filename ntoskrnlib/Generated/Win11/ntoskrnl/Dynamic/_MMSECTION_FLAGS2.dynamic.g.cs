using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSECTION_FLAGS2")]
    public sealed class _MMSECTION_FLAGS2 : DynamicStructure
    {
        public ushort PartitionId { get; }
        public byte NoCrossPartitionAccess { get; }
        public byte SubsectionCrossPartitionReferenceOverflow { get; }
        public byte UsingFileExtents { get; }

        public _MMSECTION_FLAGS2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSECTION_FLAGS2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSECTION_FLAGS2.PartitionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS2.NoCrossPartitionAccess),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS2.SubsectionCrossPartitionReferenceOverflow),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS2.UsingFileExtents),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_MMSECTION_FLAGS2>((mem, ptr) => new _MMSECTION_FLAGS2(mem, ptr), offsets);
        }
    }
}