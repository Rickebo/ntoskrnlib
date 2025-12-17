using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY")]
    public sealed class _CM_KEY_SECURITY : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Reserved { get; }
        public uint Flink { get; }
        public uint Blink { get; }
        public uint ReferenceCount { get; }
        public uint DescriptorLength { get; }
        public _SECURITY_DESCRIPTOR_RELATIVE Descriptor { get; }

        public _CM_KEY_SECURITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_SECURITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_SECURITY.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.Flink),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.Blink),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.ReferenceCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.DescriptorLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY.Descriptor),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_CM_KEY_SECURITY>((mem, ptr) => new _CM_KEY_SECURITY(mem, ptr), offsets);
        }
    }
}