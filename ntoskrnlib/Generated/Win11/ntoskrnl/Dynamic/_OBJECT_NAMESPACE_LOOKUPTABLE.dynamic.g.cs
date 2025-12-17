using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_NAMESPACE_LOOKUPTABLE")]
    public sealed class _OBJECT_NAMESPACE_LOOKUPTABLE : DynamicStructure
    {
        public byte[] HashBuckets { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public uint NumberOfPrivateSpaces { get; }

        public _OBJECT_NAMESPACE_LOOKUPTABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_NAMESPACE_LOOKUPTABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_NAMESPACE_LOOKUPTABLE.HashBuckets),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_NAMESPACE_LOOKUPTABLE.Lock),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_OBJECT_NAMESPACE_LOOKUPTABLE.NumberOfPrivateSpaces),
                    new ulong[]
                    {
                        600UL
                    }
                }
            };
            Register<_OBJECT_NAMESPACE_LOOKUPTABLE>((mem, ptr) => new _OBJECT_NAMESPACE_LOOKUPTABLE(mem, ptr), offsets);
        }
    }
}