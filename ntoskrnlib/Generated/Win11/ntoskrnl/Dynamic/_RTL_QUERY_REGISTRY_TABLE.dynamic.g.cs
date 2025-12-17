using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_QUERY_REGISTRY_TABLE")]
    public sealed class _RTL_QUERY_REGISTRY_TABLE : DynamicStructure
    {
        public IntPtr QueryRoutine { get; }
        public uint Flags { get; }
        public IntPtr Name { get; }
        public IntPtr EntryContext { get; }
        public uint DefaultType { get; }
        public IntPtr DefaultData { get; }
        public uint DefaultLength { get; }

        public _RTL_QUERY_REGISTRY_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_QUERY_REGISTRY_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.QueryRoutine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.Name),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.EntryContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.DefaultType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.DefaultData),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_QUERY_REGISTRY_TABLE.DefaultLength),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_RTL_QUERY_REGISTRY_TABLE>((mem, ptr) => new _RTL_QUERY_REGISTRY_TABLE(mem, ptr), offsets);
        }
    }
}