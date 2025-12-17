using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_APC_POOL")]
    public sealed class _ETW_APC_POOL : DynamicStructure
    {
        public IntPtr LoggerContext { get; }
        public ulong ApcSpinLock { get; }
        public _SLIST_HEADER ApcGlobalListHead { get; }
        public _SLIST_HEADER ApcFreeListHead { get; }
        public IntPtr DpcContext1 { get; }
        public IntPtr DpcContext2 { get; }
        public IntPtr DpcContext3 { get; }
        public IntPtr DpcNormalRoutine { get; }
        public IntPtr DpcCancelRoutine { get; }
        public IntPtr DpcThread { get; }
        public _KDPC Dpc { get; }
        public int Flags { get; }
        public int ApcCount { get; }
        public uint MinimumApcCount { get; }
        public uint MaximumApcCount { get; }
        public int OutstandingApcCount { get; }
        public int MaxOutstandingApcCount { get; }

        public _ETW_APC_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_APC_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_APC_POOL.LoggerContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.ApcSpinLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.ApcGlobalListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.ApcFreeListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcContext1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcContext2),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcContext3),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcNormalRoutine),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcCancelRoutine),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.DpcThread),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.Dpc),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.Flags),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.ApcCount),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.MinimumApcCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.MaximumApcCount),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.OutstandingApcCount),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_ETW_APC_POOL.MaxOutstandingApcCount),
                    new ulong[]
                    {
                        180UL
                    }
                }
            };
            Register<_ETW_APC_POOL>((mem, ptr) => new _ETW_APC_POOL(mem, ptr), offsets);
        }
    }
}