using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_LOGGER_HANDLE")]
    public sealed class EtwLoggerHandle : DynamicStructure
    {
        [Offset(0UL)]
        public byte DereferenceAndLeave { get => ReadHere<byte>(nameof(DereferenceAndLeave)); set => WriteHere(nameof(DereferenceAndLeave), value); }

        public EtwLoggerHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwLoggerHandle>();
        }
    }
}