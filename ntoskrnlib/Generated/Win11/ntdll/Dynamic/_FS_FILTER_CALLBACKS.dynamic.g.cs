using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_FS_FILTER_CALLBACKS")]
    public sealed class _FS_FILTER_CALLBACKS : DynamicStructure
    {
        public uint SizeOfFsFilterCallbacks { get; }
        public uint Reserved { get; }
        public IntPtr PreAcquireForSectionSynchronization { get; }
        public IntPtr PostAcquireForSectionSynchronization { get; }
        public IntPtr PreReleaseForSectionSynchronization { get; }
        public IntPtr PostReleaseForSectionSynchronization { get; }
        public IntPtr PreAcquireForCcFlush { get; }
        public IntPtr PostAcquireForCcFlush { get; }
        public IntPtr PreReleaseForCcFlush { get; }
        public IntPtr PostReleaseForCcFlush { get; }
        public IntPtr PreAcquireForModifiedPageWriter { get; }
        public IntPtr PostAcquireForModifiedPageWriter { get; }
        public IntPtr PreReleaseForModifiedPageWriter { get; }
        public IntPtr PostReleaseForModifiedPageWriter { get; }
        public IntPtr PreQueryOpen { get; }
        public IntPtr PostQueryOpen { get; }

        public _FS_FILTER_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FS_FILTER_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FS_FILTER_CALLBACKS.SizeOfFsFilterCallbacks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreAcquireForSectionSynchronization),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostAcquireForSectionSynchronization),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreReleaseForSectionSynchronization),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostReleaseForSectionSynchronization),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreAcquireForCcFlush),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostAcquireForCcFlush),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreReleaseForCcFlush),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostReleaseForCcFlush),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreAcquireForModifiedPageWriter),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostAcquireForModifiedPageWriter),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreReleaseForModifiedPageWriter),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostReleaseForModifiedPageWriter),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PreQueryOpen),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACKS.PostQueryOpen),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_FS_FILTER_CALLBACKS>((mem, ptr) => new _FS_FILTER_CALLBACKS(mem, ptr), offsets);
        }
    }
}