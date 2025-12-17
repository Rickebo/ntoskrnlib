using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_WMITRACE_WORK")]
    public sealed class _ETW_WMITRACE_WORK : DynamicStructure
    {
        public uint LoggerId { get; }
        public uint SiloSessionId { get; }
        public sbyte[] LoggerName { get; }
        public sbyte[] FileName { get; }
        public uint MaximumFileSize { get; }
        public uint MinBuffers { get; }
        public uint MaxBuffers { get; }
        public uint BufferSize { get; }
        public uint Mode { get; }
        public uint FlushTimer { get; }
        public ulong MatchAny { get; }
        public ulong MatchAll { get; }
        public uint EnableProperty { get; }
        public _GUID Guid { get; }
        public byte Level { get; }
        public int Status { get; }

        public _ETW_WMITRACE_WORK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_WMITRACE_WORK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_WMITRACE_WORK.LoggerId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.SiloSessionId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.LoggerName),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.FileName),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.MaximumFileSize),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.MinBuffers),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.MaxBuffers),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.BufferSize),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.Mode),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.FlushTimer),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.MatchAny),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.MatchAll),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.EnableProperty),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.Guid),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.Level),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_ETW_WMITRACE_WORK.Status),
                    new ulong[]
                    {
                        232UL
                    }
                }
            };
            Register<_ETW_WMITRACE_WORK>((mem, ptr) => new _ETW_WMITRACE_WORK(mem, ptr), offsets);
        }
    }
}