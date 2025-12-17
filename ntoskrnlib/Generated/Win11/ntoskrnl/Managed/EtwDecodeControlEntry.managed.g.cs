using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_DECODE_CONTROL_ENTRY")]
    public sealed class EtwDecodeControlEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public Guid Decode { get => ReadStructure<Guid>(nameof(Decode)); set => WriteStructure(nameof(Decode), value); }

        [Offset(24UL)]
        public Guid Control { get => ReadStructure<Guid>(nameof(Control)); set => WriteStructure(nameof(Control), value); }

        [Offset(40UL)]
        public byte ConsumersNotified { get => ReadHere<byte>(nameof(ConsumersNotified)); set => WriteHere(nameof(ConsumersNotified), value); }

        public EtwDecodeControlEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwDecodeControlEntry>();
        }
    }
}