using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PENDING_RELATIONS_LIST_ENTRY")]
    public sealed class _PENDING_RELATIONS_LIST_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr DeviceEvent { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr RelationsList { get; }
        public IntPtr EjectIrp { get; }
        public uint Lock { get; }
        public uint Problem { get; }
        public byte ProfileChangingEject { get; }
        public byte DisplaySafeRemovalDialog { get; }
        public uint LightestSleepState { get; }
        public IntPtr DockInterface { get; }
        public byte DequeuePending { get; }
        public uint DeleteType { get; }

        public _PENDING_RELATIONS_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PENDING_RELATIONS_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.WorkItem),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DeviceEvent),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DeviceObject),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.RelationsList),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.EjectIrp),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.Lock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.Problem),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.ProfileChangingEject),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DisplaySafeRemovalDialog),
                    new ulong[]
                    {
                        89UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.LightestSleepState),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DockInterface),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DequeuePending),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PENDING_RELATIONS_LIST_ENTRY.DeleteType),
                    new ulong[]
                    {
                        108UL
                    }
                }
            };
            Register<_PENDING_RELATIONS_LIST_ENTRY>((mem, ptr) => new _PENDING_RELATIONS_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}