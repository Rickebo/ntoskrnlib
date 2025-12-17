using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE_STATE")]
    public sealed class InterruptLineState : DynamicStructure
    {
        [Offset(0UL)]
        public uint Polarity { get => ReadHere<uint>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(4UL)]
        public byte EmulateActiveBoth { get => ReadHere<byte>(nameof(EmulateActiveBoth)); set => WriteHere(nameof(EmulateActiveBoth), value); }

        [Offset(8UL)]
        public uint TriggerMode { get => ReadHere<uint>(nameof(TriggerMode)); set => WriteHere(nameof(TriggerMode), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public InterruptLine Routing { get => ReadStructure<InterruptLine>(nameof(Routing)); set => WriteStructure(nameof(Routing), value); }

        [Offset(24UL)]
        public InterruptTarget ProcessorTarget { get => ReadStructure<InterruptTarget>(nameof(ProcessorTarget)); set => WriteStructure(nameof(ProcessorTarget), value); }

        [Offset(48UL)]
        public uint Vector { get => ReadHere<uint>(nameof(Vector)); set => WriteHere(nameof(Vector), value); }

        [Offset(52UL)]
        public uint Priority { get => ReadHere<uint>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        public InterruptLineState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptLineState>();
        }
    }
}