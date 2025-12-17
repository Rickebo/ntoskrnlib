using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEM_LOGGER")]
    public sealed class EtwSystemLogger : DynamicStructure
    {
        [Offset(0UL)]
        public byte LoggerId { get => ReadHere<byte>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(1UL)]
        public byte ClockType { get => ReadHere<byte>(nameof(ClockType)); set => WriteHere(nameof(ClockType), value); }

        public EtwSystemLogger(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSystemLogger>();
        }
    }
}