using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOG_HANDLE_CONTEXT")]
    public sealed class _LOG_HANDLE_CONTEXT : DynamicStructure
    {
        public IntPtr LogHandle { get; }
        public IntPtr FlushToLsnRoutine { get; }
        public IntPtr QueryLogHandleInfoRoutine { get; }
        public _DIRTY_PAGE_STATISTICS DirtyPageStatistics { get; }
        public _DIRTY_PAGE_THRESHOLDS DirtyPageThresholds { get; }
        public uint AdditionalPagesToWrite { get; }
        public uint CcLWScanDPThreshold { get; }
        public _LARGE_INTEGER LargestLsnForCurrentLWScan { get; }
        public IntPtr RelatedFileObject { get; }
        public ulong LargestLsnFileObjectKey { get; }
        public _LARGE_INTEGER LastLWTimeStamp { get; }
        public uint Flags { get; }

        public _LOG_HANDLE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOG_HANDLE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOG_HANDLE_CONTEXT.LogHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.FlushToLsnRoutine),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.QueryLogHandleInfoRoutine),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.DirtyPageStatistics),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.DirtyPageThresholds),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.AdditionalPagesToWrite),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.CcLWScanDPThreshold),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.LargestLsnForCurrentLWScan),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.RelatedFileObject),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.LargestLsnFileObjectKey),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.LastLWTimeStamp),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_LOG_HANDLE_CONTEXT.Flags),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_LOG_HANDLE_CONTEXT>((mem, ptr) => new _LOG_HANDLE_CONTEXT(mem, ptr), offsets);
        }
    }
}