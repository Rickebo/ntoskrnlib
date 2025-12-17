using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CONFIGURATION_COMPONENT")]
    public sealed class _CONFIGURATION_COMPONENT : DynamicStructure
    {
        public uint Class { get; }
        public uint Type { get; }
        public _DEVICE_FLAGS Flags { get; }
        public ushort Version { get; }
        public ushort Revision { get; }
        public uint Key { get; }
        public uint AffinityMask { get; }
        public ushort Group { get; }
        public ushort GroupIndex { get; }
        public uint ConfigurationDataLength { get; }
        public uint IdentifierLength { get; }
        public IntPtr Identifier { get; }

        public _CONFIGURATION_COMPONENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CONFIGURATION_COMPONENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CONFIGURATION_COMPONENT.Class),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Type),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Version),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Revision),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Key),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.AffinityMask),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Group),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.GroupIndex),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.ConfigurationDataLength),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.IdentifierLength),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT.Identifier),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_CONFIGURATION_COMPONENT>((mem, ptr) => new _CONFIGURATION_COMPONENT(mem, ptr), offsets);
        }
    }
}