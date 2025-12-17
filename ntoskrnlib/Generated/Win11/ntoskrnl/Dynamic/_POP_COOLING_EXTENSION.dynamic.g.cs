using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_COOLING_EXTENSION")]
    public sealed class _POP_COOLING_EXTENSION : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public _LIST_ENTRY RequestListHead { get; }
        public _POP_RW_LOCK Lock { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr NotificationEntry { get; }
        public byte Enabled { get; }
        public byte ActiveEngaged { get; }
        public byte ThrottleLimit { get; }
        public byte UpdatingToCurrent { get; }
        public IntPtr RemovalFlushEvent { get; }
        public IntPtr PnpFlushEvent { get; }
        public _THERMAL_COOLING_INTERFACE Interface { get; }

        public _POP_COOLING_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_COOLING_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_COOLING_EXTENSION.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.RequestListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.Lock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.DeviceObject),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.NotificationEntry),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.Enabled),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.ActiveEngaged),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.ThrottleLimit),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.UpdatingToCurrent),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.RemovalFlushEvent),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.PnpFlushEvent),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_COOLING_EXTENSION.Interface),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_POP_COOLING_EXTENSION>((mem, ptr) => new _POP_COOLING_EXTENSION(mem, ptr), offsets);
        }
    }
}