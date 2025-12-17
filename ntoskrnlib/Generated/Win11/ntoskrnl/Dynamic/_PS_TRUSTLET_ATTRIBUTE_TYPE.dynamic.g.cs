using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_TRUSTLET_ATTRIBUTE_TYPE")]
    public sealed class _PS_TRUSTLET_ATTRIBUTE_TYPE : DynamicStructure
    {
        public byte Version { get; }
        public byte DataCount { get; }
        public byte SemanticType { get; }
        public _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS AccessRights { get; }
        public uint AttributeType { get; }

        public _PS_TRUSTLET_ATTRIBUTE_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_ATTRIBUTE_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_TYPE.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_TYPE.DataCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_TYPE.SemanticType),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_TYPE.AccessRights),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_TYPE.AttributeType),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_TRUSTLET_ATTRIBUTE_TYPE>((mem, ptr) => new _PS_TRUSTLET_ATTRIBUTE_TYPE(mem, ptr), offsets);
        }
    }
}