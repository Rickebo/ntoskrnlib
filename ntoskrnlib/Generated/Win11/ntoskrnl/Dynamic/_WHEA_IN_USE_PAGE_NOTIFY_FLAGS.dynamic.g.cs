using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_IN_USE_PAGE_NOTIFY_FLAGS")]
    public sealed class _WHEA_IN_USE_PAGE_NOTIFY_FLAGS : DynamicStructure
    {
        public _unnamed_tag_ Bits { get; }
        public byte AsUCHAR { get; }

        public _WHEA_IN_USE_PAGE_NOTIFY_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_IN_USE_PAGE_NOTIFY_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_IN_USE_PAGE_NOTIFY_FLAGS.Bits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_IN_USE_PAGE_NOTIFY_FLAGS.AsUCHAR),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_IN_USE_PAGE_NOTIFY_FLAGS>((mem, ptr) => new _WHEA_IN_USE_PAGE_NOTIFY_FLAGS(mem, ptr), offsets);
        }
    }
}