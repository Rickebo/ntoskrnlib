using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRACE_LOGFILE_HEADER")]
    public sealed class _TRACE_LOGFILE_HEADER : DynamicStructure
    {
        public uint BufferSize { get; }
        public uint Version { get; }
        public _unnamed_tag_ VersionDetail { get; }
        public uint ProviderVersion { get; }
        public uint NumberOfProcessors { get; }
        public _LARGE_INTEGER EndTime { get; }
        public uint TimerResolution { get; }
        public uint MaximumFileSize { get; }
        public uint LogFileMode { get; }
        public uint BuffersWritten { get; }
        public _GUID LogInstanceGuid { get; }
        public uint StartBuffers { get; }
        public uint PointerSize { get; }
        public uint EventsLost { get; }
        public uint CpuSpeedInMHz { get; }
        public IntPtr LoggerName { get; }
        public IntPtr LogFileName { get; }
        public _RTL_TIME_ZONE_INFORMATION TimeZone { get; }
        public _LARGE_INTEGER BootTime { get; }
        public _LARGE_INTEGER PerfFreq { get; }
        public _LARGE_INTEGER StartTime { get; }
        public uint ReservedFlags { get; }
        public uint BuffersLost { get; }

        public _TRACE_LOGFILE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRACE_LOGFILE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRACE_LOGFILE_HEADER.BufferSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.Version),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.VersionDetail),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.ProviderVersion),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.NumberOfProcessors),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.EndTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.TimerResolution),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.MaximumFileSize),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.LogFileMode),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.BuffersWritten),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.LogInstanceGuid),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.StartBuffers),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.PointerSize),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.EventsLost),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.CpuSpeedInMHz),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.LoggerName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.LogFileName),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.TimeZone),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.BootTime),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.PerfFreq),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.StartTime),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.ReservedFlags),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TRACE_LOGFILE_HEADER.BuffersLost),
                    new ulong[]
                    {
                        276UL
                    }
                }
            };
            Register<_TRACE_LOGFILE_HEADER>((mem, ptr) => new _TRACE_LOGFILE_HEADER(mem, ptr), offsets);
        }
    }
}