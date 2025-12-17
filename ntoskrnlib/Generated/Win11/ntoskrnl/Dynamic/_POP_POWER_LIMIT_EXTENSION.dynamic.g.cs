using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_POWER_LIMIT_EXTENSION")]
    public sealed class _POP_POWER_LIMIT_EXTENSION : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public _LIST_ENTRY RequestListHead { get; }
        public _POP_RW_LOCK Lock { get; }
        public byte Enabled { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr NotificationEntry { get; }
        public uint LimitCount { get; }
        public IntPtr LimitAttributes { get; }
        public IntPtr LimitValues { get; }
        public uint UpdateMaskCount { get; }
        public IntPtr UpdateMask { get; }
        public _POWER_LIMIT_INTERFACE Interface { get; }
        public uint PendingSetCount { get; }
        public uint PendingQueryCount { get; }
        public IntPtr RemovalFlushEvent { get; }
        public IntPtr PnpFlushEvent { get; }

        public _POP_POWER_LIMIT_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_POWER_LIMIT_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.RequestListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.Lock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.Enabled),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.DeviceObject),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.NotificationEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.LimitCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.LimitAttributes),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.LimitValues),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.UpdateMaskCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.UpdateMask),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.Interface),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.PendingSetCount),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.PendingQueryCount),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.RemovalFlushEvent),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_POP_POWER_LIMIT_EXTENSION.PnpFlushEvent),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_POP_POWER_LIMIT_EXTENSION>((mem, ptr) => new _POP_POWER_LIMIT_EXTENSION(mem, ptr), offsets);
        }
    }
}