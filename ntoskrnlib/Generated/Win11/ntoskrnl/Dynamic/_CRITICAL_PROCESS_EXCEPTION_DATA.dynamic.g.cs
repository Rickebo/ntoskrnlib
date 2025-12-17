using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CRITICAL_PROCESS_EXCEPTION_DATA")]
    public sealed class _CRITICAL_PROCESS_EXCEPTION_DATA : DynamicStructure
    {
        public _GUID ReportId { get; }
        public _UNICODE_STRING ModuleName { get; }
        public uint ModuleTimestamp { get; }
        public uint ModuleSize { get; }
        public ulong Offset { get; }

        public _CRITICAL_PROCESS_EXCEPTION_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CRITICAL_PROCESS_EXCEPTION_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CRITICAL_PROCESS_EXCEPTION_DATA.ReportId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CRITICAL_PROCESS_EXCEPTION_DATA.ModuleName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CRITICAL_PROCESS_EXCEPTION_DATA.ModuleTimestamp),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CRITICAL_PROCESS_EXCEPTION_DATA.ModuleSize),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_CRITICAL_PROCESS_EXCEPTION_DATA.Offset),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_CRITICAL_PROCESS_EXCEPTION_DATA>((mem, ptr) => new _CRITICAL_PROCESS_EXCEPTION_DATA(mem, ptr), offsets);
        }
    }
}