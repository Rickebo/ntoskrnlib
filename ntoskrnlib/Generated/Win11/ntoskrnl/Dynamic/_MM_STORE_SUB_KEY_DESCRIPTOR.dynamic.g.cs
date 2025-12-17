using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_STORE_SUB_KEY_DESCRIPTOR")]
    public sealed class _MM_STORE_SUB_KEY_DESCRIPTOR : DynamicStructure
    {
        public _unnamed_tag_ Flags { get; }
        public IntPtr VirtualAddress { get; }

        public _MM_STORE_SUB_KEY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_STORE_SUB_KEY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_STORE_SUB_KEY_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_STORE_SUB_KEY_DESCRIPTOR.VirtualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MM_STORE_SUB_KEY_DESCRIPTOR>((mem, ptr) => new _MM_STORE_SUB_KEY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}