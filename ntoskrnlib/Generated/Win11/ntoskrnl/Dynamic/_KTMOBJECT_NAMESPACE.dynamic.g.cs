using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTMOBJECT_NAMESPACE")]
    public sealed class _KTMOBJECT_NAMESPACE : DynamicStructure
    {
        public _RTL_AVL_TABLE Table { get; }
        public _KMUTANT Mutex { get; }
        public ushort LinksOffset { get; }
        public ushort GuidOffset { get; }
        public byte Expired { get; }

        public _KTMOBJECT_NAMESPACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTMOBJECT_NAMESPACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTMOBJECT_NAMESPACE.Table),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTMOBJECT_NAMESPACE.Mutex),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KTMOBJECT_NAMESPACE.LinksOffset),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KTMOBJECT_NAMESPACE.GuidOffset),
                    new ulong[]
                    {
                        162UL
                    }
                },
                {
                    nameof(_KTMOBJECT_NAMESPACE.Expired),
                    new ulong[]
                    {
                        164UL
                    }
                }
            };
            Register<_KTMOBJECT_NAMESPACE>((mem, ptr) => new _KTMOBJECT_NAMESPACE(mem, ptr), offsets);
        }
    }
}