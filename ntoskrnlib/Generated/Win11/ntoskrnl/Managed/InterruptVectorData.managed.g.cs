using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_VECTOR_DATA")]
    public sealed class InterruptVectorData : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint Vector { get => ReadHere<uint>(nameof(Vector)); set => WriteHere(nameof(Vector), value); }

        [Offset(8UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(12UL)]
        public uint Polarity { get => ReadHere<uint>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(16UL)]
        public uint Mode { get => ReadHere<uint>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(24UL)]
        public GroupAffinity TargetProcessors { get => ReadStructure<GroupAffinity>(nameof(TargetProcessors)); set => WriteStructure(nameof(TargetProcessors), value); }

        [Offset(40UL)]
        public InterruptRemappingInfo IntRemapInfo { get => ReadStructure<InterruptRemappingInfo>(nameof(IntRemapInfo)); set => WriteStructure(nameof(IntRemapInfo), value); }

        [Offset(56UL)]
        public UnnamedTag ControllerInput { get => ReadStructure<UnnamedTag>(nameof(ControllerInput)); set => WriteStructure(nameof(ControllerInput), value); }

        [Offset(64UL)]
        public ulong HvDeviceId { get => ReadHere<ulong>(nameof(HvDeviceId)); set => WriteHere(nameof(HvDeviceId), value); }

        [Offset(72UL)]
        public UnnamedTag XapicMessage { get => ReadStructure<UnnamedTag>(nameof(XapicMessage)); set => WriteStructure(nameof(XapicMessage), value); }

        [Offset(72UL)]
        public UnnamedTag Hypertransport { get => ReadStructure<UnnamedTag>(nameof(Hypertransport)); set => WriteStructure(nameof(Hypertransport), value); }

        [Offset(72UL)]
        public UnnamedTag GenericMessage { get => ReadStructure<UnnamedTag>(nameof(GenericMessage)); set => WriteStructure(nameof(GenericMessage), value); }

        [Offset(72UL)]
        public UnnamedTag MessageRequest { get => ReadStructure<UnnamedTag>(nameof(MessageRequest)); set => WriteStructure(nameof(MessageRequest), value); }

        public InterruptVectorData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptVectorData>();
        }
    }
}