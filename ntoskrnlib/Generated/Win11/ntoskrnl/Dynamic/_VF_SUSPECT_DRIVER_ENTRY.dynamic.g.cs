using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_SUSPECT_DRIVER_ENTRY")]
    public sealed class _VF_SUSPECT_DRIVER_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public uint Loads { get; }
        public uint Unloads { get; }
        public _UNICODE_STRING FullName { get; }
        public _UNICODE_STRING BaseName { get; }

        public _VF_SUSPECT_DRIVER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_SUSPECT_DRIVER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_SUSPECT_DRIVER_ENTRY.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_SUSPECT_DRIVER_ENTRY.Loads),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_SUSPECT_DRIVER_ENTRY.Unloads),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_VF_SUSPECT_DRIVER_ENTRY.FullName),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VF_SUSPECT_DRIVER_ENTRY.BaseName),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_VF_SUSPECT_DRIVER_ENTRY>((mem, ptr) => new _VF_SUSPECT_DRIVER_ENTRY(mem, ptr), offsets);
        }
    }
}