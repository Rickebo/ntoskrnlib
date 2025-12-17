using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_LARGEPAGE_VAD_INFO")]
    public sealed class _MI_LARGEPAGE_VAD_INFO : DynamicStructure
    {
        public byte LargeImageBias { get; }
        public byte[] Spare { get; }
        public ulong ActualImageViewSize { get; }
        public IntPtr ReferencedPartition { get; }

        public _MI_LARGEPAGE_VAD_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_LARGEPAGE_VAD_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_LARGEPAGE_VAD_INFO.LargeImageBias),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_LARGEPAGE_VAD_INFO.Spare),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MI_LARGEPAGE_VAD_INFO.ActualImageViewSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_LARGEPAGE_VAD_INFO.ReferencedPartition),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_LARGEPAGE_VAD_INFO>((mem, ptr) => new _MI_LARGEPAGE_VAD_INFO(mem, ptr), offsets);
        }
    }
}