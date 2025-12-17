using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_INVPCID_DESCRIPTOR")]
    public sealed class _INVPCID_DESCRIPTOR : DynamicStructure
    {
        public _unnamed_tag_ IndividualAddress { get; }
        public _unnamed_tag_ SingleContext { get; }
        public _unnamed_tag_ AllContextAndGlobals { get; }
        public _unnamed_tag_ AllContext { get; }

        public _INVPCID_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INVPCID_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INVPCID_DESCRIPTOR.IndividualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVPCID_DESCRIPTOR.SingleContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVPCID_DESCRIPTOR.AllContextAndGlobals),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVPCID_DESCRIPTOR.AllContext),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_INVPCID_DESCRIPTOR>((mem, ptr) => new _INVPCID_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}