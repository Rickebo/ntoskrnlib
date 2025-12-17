using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_SRWLOCK")]
    public sealed class _RTL_SRWLOCK : DynamicStructure
    {
        public ulong Locked { get; }
        public ulong Waiting { get; }
        public ulong Waking { get; }
        public ulong MultipleShared { get; }
        public ulong Shared { get; }
        public ulong Value { get; }
        public IntPtr Ptr { get; }

        public _RTL_SRWLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_SRWLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_SRWLOCK.Locked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.Waiting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.Waking),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.MultipleShared),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.Shared),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_SRWLOCK.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_SRWLOCK>((mem, ptr) => new _RTL_SRWLOCK(mem, ptr), offsets);
        }
    }
}