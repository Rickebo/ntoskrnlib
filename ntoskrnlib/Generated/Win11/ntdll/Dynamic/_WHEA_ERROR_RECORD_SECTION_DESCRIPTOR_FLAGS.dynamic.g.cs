using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS")]
    public sealed class _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS : DynamicStructure
    {
        public uint Primary { get; }
        public uint ContainmentWarning { get; }
        public uint Reset { get; }
        public uint ThresholdExceeded { get; }
        public uint ResourceNotAvailable { get; }
        public uint LatentError { get; }
        public uint Propagated { get; }
        public uint FruTextByPlugin { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.Primary),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.ContainmentWarning),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.Reset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.ThresholdExceeded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.ResourceNotAvailable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.LatentError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.Propagated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.FruTextByPlugin),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS>((mem, ptr) => new _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS(mem, ptr), offsets);
        }
    }
}