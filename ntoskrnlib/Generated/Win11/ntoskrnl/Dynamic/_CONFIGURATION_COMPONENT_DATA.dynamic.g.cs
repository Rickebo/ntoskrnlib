using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CONFIGURATION_COMPONENT_DATA")]
    public sealed class _CONFIGURATION_COMPONENT_DATA : DynamicStructure
    {
        public IntPtr Parent { get; }
        public IntPtr Child { get; }
        public IntPtr Sibling { get; }
        public _CONFIGURATION_COMPONENT ComponentEntry { get; }
        public IntPtr ConfigurationData { get; }

        public _CONFIGURATION_COMPONENT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CONFIGURATION_COMPONENT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CONFIGURATION_COMPONENT_DATA.Parent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT_DATA.Child),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT_DATA.Sibling),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT_DATA.ComponentEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CONFIGURATION_COMPONENT_DATA.ConfigurationData),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_CONFIGURATION_COMPONENT_DATA>((mem, ptr) => new _CONFIGURATION_COMPONENT_DATA(mem, ptr), offsets);
        }
    }
}