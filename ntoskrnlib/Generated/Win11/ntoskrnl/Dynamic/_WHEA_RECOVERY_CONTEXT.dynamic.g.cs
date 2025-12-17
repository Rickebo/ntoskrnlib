using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT")]
    public sealed class _WHEA_RECOVERY_CONTEXT : DynamicStructure
    {
        public _unnamed_tag_ MemoryError { get; }
        public _unnamed_tag_ PmemError { get; }
        public ulong PartitionId { get; }
        public uint VpIndex { get; }
        public uint ErrorType { get; }
        public uint PageCount { get; }
        public byte[] PageInfo { get; }

        public _WHEA_RECOVERY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_RECOVERY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.MemoryError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.PmemError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.PartitionId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.VpIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.ErrorType),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.PageCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT.PageInfo),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_WHEA_RECOVERY_CONTEXT>((mem, ptr) => new _WHEA_RECOVERY_CONTEXT(mem, ptr), offsets);
        }
    }
}