using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_LOG_REGISTER_CONTEXT")]
    public sealed class HalLogRegisterContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LogRoutine { get => ReadHere<IntPtr>(nameof(LogRoutine)); set => WriteHere(nameof(LogRoutine), value); }

        [Offset(8UL)]
        public uint Flag { get => ReadHere<uint>(nameof(Flag)); set => WriteHere(nameof(Flag), value); }

        public HalLogRegisterContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalLogRegisterContext>();
        }
    }
}