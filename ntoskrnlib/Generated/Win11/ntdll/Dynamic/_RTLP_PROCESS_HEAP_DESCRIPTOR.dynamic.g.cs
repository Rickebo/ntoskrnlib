using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTLP_PROCESS_HEAP_DESCRIPTOR")]
    public sealed class _RTLP_PROCESS_HEAP_DESCRIPTOR : DynamicStructure
    {
        public _LIST_ENTRY DescriptorLink { get; }
        public IntPtr Heap { get; }
        public _unnamed_tag_ Flags { get; }
        public _unnamed_tag_ PseudoGlobalLock { get; }

        public _RTLP_PROCESS_HEAP_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_PROCESS_HEAP_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_PROCESS_HEAP_DESCRIPTOR.DescriptorLink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_PROCESS_HEAP_DESCRIPTOR.Heap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTLP_PROCESS_HEAP_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTLP_PROCESS_HEAP_DESCRIPTOR.PseudoGlobalLock),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_RTLP_PROCESS_HEAP_DESCRIPTOR>((mem, ptr) => new _RTLP_PROCESS_HEAP_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}