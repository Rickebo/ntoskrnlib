using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_PUSH_LOCK")]
    public sealed class _EX_PUSH_LOCK : DynamicStructure
    {
        public ulong Locked { get; }
        public ulong Waiting { get; }
        public ulong Waking { get; }
        public ulong MultipleShared { get; }
        public ulong Shared { get; }
        public ulong Value { get; }
        public IntPtr Ptr { get; }

        public _EX_PUSH_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_PUSH_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_PUSH_LOCK.Locked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.Waiting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.Waking),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.MultipleShared),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.Shared),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EX_PUSH_LOCK>((mem, ptr) => new _EX_PUSH_LOCK(mem, ptr), offsets);
        }
    }
}