using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY_CACHE")]
    public sealed class _CM_KEY_SECURITY_CACHE : DynamicStructure
    {
        public uint Cell { get; }
        public uint ConvKey { get; }
        public _LIST_ENTRY List { get; }
        public uint DescriptorLength { get; }
        public uint RealRefCount { get; }
        public _SECURITY_DESCRIPTOR_RELATIVE Descriptor { get; }

        public _CM_KEY_SECURITY_CACHE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_SECURITY_CACHE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_SECURITY_CACHE.Cell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE.ConvKey),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE.List),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE.DescriptorLength),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE.RealRefCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE.Descriptor),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_CM_KEY_SECURITY_CACHE>((mem, ptr) => new _CM_KEY_SECURITY_CACHE(mem, ptr), offsets);
        }
    }
}