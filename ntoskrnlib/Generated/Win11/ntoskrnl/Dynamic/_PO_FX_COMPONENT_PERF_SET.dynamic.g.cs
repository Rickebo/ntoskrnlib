using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_FX_COMPONENT_PERF_SET")]
    public sealed class _PO_FX_COMPONENT_PERF_SET : DynamicStructure
    {
        public _UNICODE_STRING Name { get; }
        public ulong Flags { get; }
        public uint Unit { get; }
        public uint Type { get; }
        public _unnamed_tag_ Discrete { get; }
        public _unnamed_tag_ Range { get; }

        public _PO_FX_COMPONENT_PERF_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_FX_COMPONENT_PERF_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Name),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Unit),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Type),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Discrete),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PO_FX_COMPONENT_PERF_SET.Range),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PO_FX_COMPONENT_PERF_SET>((mem, ptr) => new _PO_FX_COMPONENT_PERF_SET(mem, ptr), offsets);
        }
    }
}