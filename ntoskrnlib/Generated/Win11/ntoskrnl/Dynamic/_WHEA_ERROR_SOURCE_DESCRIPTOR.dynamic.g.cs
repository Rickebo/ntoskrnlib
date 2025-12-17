using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_SOURCE_DESCRIPTOR")]
    public sealed class _WHEA_ERROR_SOURCE_DESCRIPTOR : DynamicStructure
    {
        public uint Length { get; }
        public uint Version { get; }
        public uint Type { get; }
        public uint State { get; }
        public uint MaxRawDataLength { get; }
        public uint NumRecordsToPreallocate { get; }
        public uint MaxSectionsPerRecord { get; }
        public uint ErrorSourceId { get; }
        public uint PlatformErrorSourceId { get; }
        public uint Flags { get; }
        public _unnamed_tag_ Info { get; }

        public _WHEA_ERROR_SOURCE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_SOURCE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.Version),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.State),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.MaxRawDataLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.NumRecordsToPreallocate),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.MaxSectionsPerRecord),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.ErrorSourceId),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.PlatformErrorSourceId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_DESCRIPTOR.Info),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_WHEA_ERROR_SOURCE_DESCRIPTOR>((mem, ptr) => new _WHEA_ERROR_SOURCE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}