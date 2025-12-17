using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TraceLoggingMetadata_t")]
    public sealed class _TraceLoggingMetadata_t : DynamicStructure
    {
        public uint Signature { get; }
        public ushort Size { get; }
        public byte Version { get; }
        public byte Flags { get; }
        public ulong Magic { get; }

        public _TraceLoggingMetadata_t(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TraceLoggingMetadata_t()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TraceLoggingMetadata_t.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TraceLoggingMetadata_t.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TraceLoggingMetadata_t.Version),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_TraceLoggingMetadata_t.Flags),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_TraceLoggingMetadata_t.Magic),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TraceLoggingMetadata_t>((mem, ptr) => new _TraceLoggingMetadata_t(mem, ptr), offsets);
        }
    }
}