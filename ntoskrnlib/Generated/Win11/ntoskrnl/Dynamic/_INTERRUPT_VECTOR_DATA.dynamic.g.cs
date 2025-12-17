using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_VECTOR_DATA")]
    public sealed class _INTERRUPT_VECTOR_DATA : DynamicStructure
    {
        public uint Type { get; }
        public uint Vector { get; }
        public byte Irql { get; }
        public uint Polarity { get; }
        public uint Mode { get; }
        public _GROUP_AFFINITY TargetProcessors { get; }
        public _INTERRUPT_REMAPPING_INFO IntRemapInfo { get; }
        public _unnamed_tag_ ControllerInput { get; }
        public ulong HvDeviceId { get; }
        public _unnamed_tag_ XapicMessage { get; }
        public _unnamed_tag_ Hypertransport { get; }
        public _unnamed_tag_ GenericMessage { get; }
        public _unnamed_tag_ MessageRequest { get; }

        public _INTERRUPT_VECTOR_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_VECTOR_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Vector),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Irql),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Polarity),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Mode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.TargetProcessors),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.IntRemapInfo),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.ControllerInput),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.HvDeviceId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.XapicMessage),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.Hypertransport),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.GenericMessage),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_INTERRUPT_VECTOR_DATA.MessageRequest),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_INTERRUPT_VECTOR_DATA>((mem, ptr) => new _INTERRUPT_VECTOR_DATA(mem, ptr), offsets);
        }
    }
}