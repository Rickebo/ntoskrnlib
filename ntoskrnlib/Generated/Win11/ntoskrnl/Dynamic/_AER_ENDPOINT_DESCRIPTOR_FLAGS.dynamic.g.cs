using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AER_ENDPOINT_DESCRIPTOR_FLAGS")]
    public sealed class _AER_ENDPOINT_DESCRIPTOR_FLAGS : DynamicStructure
    {
        public ushort UncorrectableErrorMaskRW { get; }
        public ushort UncorrectableErrorSeverityRW { get; }
        public ushort CorrectableErrorMaskRW { get; }
        public ushort AdvancedCapsAndControlRW { get; }
        public ushort Reserved { get; }
        public ushort AsUSHORT { get; }

        public _AER_ENDPOINT_DESCRIPTOR_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AER_ENDPOINT_DESCRIPTOR_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.UncorrectableErrorMaskRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.UncorrectableErrorSeverityRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.CorrectableErrorMaskRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.AdvancedCapsAndControlRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AER_ENDPOINT_DESCRIPTOR_FLAGS.AsUSHORT),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_AER_ENDPOINT_DESCRIPTOR_FLAGS>((mem, ptr) => new _AER_ENDPOINT_DESCRIPTOR_FLAGS(mem, ptr), offsets);
        }
    }
}