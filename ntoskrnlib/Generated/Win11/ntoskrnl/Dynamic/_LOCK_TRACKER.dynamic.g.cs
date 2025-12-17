using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOCK_TRACKER")]
    public sealed class _LOCK_TRACKER : DynamicStructure
    {
        public _RTL_BALANCED_NODE LockTrackerNode { get; }
        public IntPtr Mdl { get; }
        public IntPtr StartVa { get; }
        public ulong Count { get; }
        public uint Offset { get; }
        public uint Length { get; }
        public uint Who { get; }
        public uint Hash { get; }
        public ulong Page { get; }
        public byte[] StackTrace { get; }
        public IntPtr Process { get; }

        public _LOCK_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOCK_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOCK_TRACKER.LockTrackerNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Mdl),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.StartVa),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Count),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Offset),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Length),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Who),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Hash),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Page),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.StackTrace),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LOCK_TRACKER.Process),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_LOCK_TRACKER>((mem, ptr) => new _LOCK_TRACKER(mem, ptr), offsets);
        }
    }
}