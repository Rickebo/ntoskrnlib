using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_HANDLE_DATA")]
    public sealed class _KALPC_HANDLE_DATA : DynamicStructure
    {
        public uint ObjectType { get; }
        public uint Count { get; }
        public _OB_DUPLICATE_OBJECT_STATE DuplicateContext { get; }

        public _KALPC_HANDLE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_HANDLE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_HANDLE_DATA.ObjectType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_HANDLE_DATA.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KALPC_HANDLE_DATA.DuplicateContext),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KALPC_HANDLE_DATA>((mem, ptr) => new _KALPC_HANDLE_DATA(mem, ptr), offsets);
        }
    }
}