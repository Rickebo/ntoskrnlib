using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_TOKEN_DIAG_TRACK_ENTRY")]
    public sealed class _SEP_TOKEN_DIAG_TRACK_ENTRY : DynamicStructure
    {
        public IntPtr ProcessCid { get; }
        public IntPtr ThreadCid { get; }
        public byte[] ImageFileName { get; }
        public uint CreateMethod { get; }
        public ulong[] CreateTrace { get; }
        public int Count { get; }
        public int CaptureCount { get; }

        public _SEP_TOKEN_DIAG_TRACK_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_TOKEN_DIAG_TRACK_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.ProcessCid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.ThreadCid),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.ImageFileName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.CreateMethod),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.CreateTrace),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.Count),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_SEP_TOKEN_DIAG_TRACK_ENTRY.CaptureCount),
                    new ulong[]
                    {
                        284UL
                    }
                }
            };
            Register<_SEP_TOKEN_DIAG_TRACK_ENTRY>((mem, ptr) => new _SEP_TOKEN_DIAG_TRACK_ENTRY(mem, ptr), offsets);
        }
    }
}