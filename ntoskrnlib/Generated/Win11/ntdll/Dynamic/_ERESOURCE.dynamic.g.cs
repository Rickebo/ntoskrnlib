using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ERESOURCE")]
    public sealed class _ERESOURCE : DynamicStructure
    {
        public _LIST_ENTRY SystemResourcesList { get; }
        public IntPtr OwnerTable { get; }
        public short ActiveCount { get; }
        public ushort Flag { get; }
        public byte ReservedLowFlags { get; }
        public byte WaiterPriority { get; }
        public IntPtr SharedWaiters { get; }
        public IntPtr ExclusiveWaiters { get; }
        public _OWNER_ENTRY OwnerEntry { get; }
        public uint ActiveEntries { get; }
        public uint ContentionCount { get; }
        public uint NumberOfSharedWaiters { get; }
        public uint NumberOfExclusiveWaiters { get; }
        public sbyte MiscFlags { get; }
        public byte[] Reserved1 { get; }
        public uint ResourceTimeoutCount { get; }
        public IntPtr Address { get; }
        public ulong CreatorBackTraceIndex { get; }
        public ulong SpinLock { get; }

        public _ERESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ERESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ERESOURCE.SystemResourcesList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ERESOURCE.OwnerTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ERESOURCE.ActiveCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ERESOURCE.Flag),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_ERESOURCE.ReservedLowFlags),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_ERESOURCE.WaiterPriority),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_ERESOURCE.SharedWaiters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ERESOURCE.ExclusiveWaiters),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ERESOURCE.OwnerEntry),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ERESOURCE.ActiveEntries),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ERESOURCE.ContentionCount),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_ERESOURCE.NumberOfSharedWaiters),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ERESOURCE.NumberOfExclusiveWaiters),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_ERESOURCE.MiscFlags),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ERESOURCE.Reserved1),
                    new ulong[]
                    {
                        81UL
                    }
                },
                {
                    nameof(_ERESOURCE.ResourceTimeoutCount),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_ERESOURCE.Address),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ERESOURCE.CreatorBackTraceIndex),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ERESOURCE.SpinLock),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_ERESOURCE>((mem, ptr) => new _ERESOURCE(mem, ptr), offsets);
        }
    }
}