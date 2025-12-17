using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_ATTRIBUTES")]
    public sealed class _OBJECT_ATTRIBUTES : DynamicStructure
    {
        public uint Length { get; }
        public IntPtr RootDirectory { get; }
        public IntPtr ObjectName { get; }
        public uint Attributes { get; }
        public IntPtr SecurityDescriptor { get; }
        public IntPtr SecurityQualityOfService { get; }

        public _OBJECT_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_ATTRIBUTES.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_ATTRIBUTES.RootDirectory),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_ATTRIBUTES.ObjectName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_ATTRIBUTES.Attributes),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_ATTRIBUTES.SecurityDescriptor),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_ATTRIBUTES.SecurityQualityOfService),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_OBJECT_ATTRIBUTES>((mem, ptr) => new _OBJECT_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}