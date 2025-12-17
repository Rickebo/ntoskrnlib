using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSWAPPABLE_PAGE")]
    public sealed class _KSWAPPABLE_PAGE : DynamicStructure
    {
        public IntPtr RegionStart { get; }
        public ulong TransitionLock { get; }
        public _KSWAPPABLE_PAGE_REF_COUNT LockCount { get; }
        public _MDL Mdl { get; }
        public ulong PageNumber { get; }

        public _KSWAPPABLE_PAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSWAPPABLE_PAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSWAPPABLE_PAGE.RegionStart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE.TransitionLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE.LockCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE.Mdl),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSWAPPABLE_PAGE.PageNumber),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_KSWAPPABLE_PAGE>((mem, ptr) => new _KSWAPPABLE_PAGE(mem, ptr), offsets);
        }
    }
}