using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_AWEINFO_FLAGS")]
    public sealed class _MI_AWEINFO_FLAGS : DynamicStructure
    {
        public uint ProcessDefault { get; }
        public uint PagesLockInitialized { get; }
        public uint ZeroPagesOptional { get; }
        public uint IoSpace { get; }
        public uint LazyTbFlush { get; }
        public uint Unused { get; }
        public uint AllBits { get; }

        public _MI_AWEINFO_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_AWEINFO_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_AWEINFO_FLAGS.ProcessDefault),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.PagesLockInitialized),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.ZeroPagesOptional),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.IoSpace),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.LazyTbFlush),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AWEINFO_FLAGS.AllBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_AWEINFO_FLAGS>((mem, ptr) => new _MI_AWEINFO_FLAGS(mem, ptr), offsets);
        }
    }
}