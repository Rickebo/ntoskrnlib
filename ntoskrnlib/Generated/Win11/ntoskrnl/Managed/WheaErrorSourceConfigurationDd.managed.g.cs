using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_SOURCE_CONFIGURATION_DD")]
    public sealed class WheaErrorSourceConfigurationDd : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Initialize { get => ReadHere<IntPtr>(nameof(Initialize)); set => WriteHere(nameof(Initialize), value); }

        [Offset(8UL)]
        public IntPtr Uninitialize { get => ReadHere<IntPtr>(nameof(Uninitialize)); set => WriteHere(nameof(Uninitialize), value); }

        [Offset(16UL)]
        public IntPtr Correct { get => ReadHere<IntPtr>(nameof(Correct)); set => WriteHere(nameof(Correct), value); }

        public WheaErrorSourceConfigurationDd(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorSourceConfigurationDd>();
        }
    }
}