using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTMOBJECT_NAMESPACE_LINK")]
    public sealed class _KTMOBJECT_NAMESPACE_LINK : DynamicStructure
    {
        public _RTL_BALANCED_LINKS Links { get; }
        public byte Expired { get; }

        public _KTMOBJECT_NAMESPACE_LINK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTMOBJECT_NAMESPACE_LINK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTMOBJECT_NAMESPACE_LINK.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTMOBJECT_NAMESPACE_LINK.Expired),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_KTMOBJECT_NAMESPACE_LINK>((mem, ptr) => new _KTMOBJECT_NAMESPACE_LINK(mem, ptr), offsets);
        }
    }
}