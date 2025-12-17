using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT_ATTRIBUTE")]
    public sealed class tagSWITCHContextAttribute : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ulContextUpdateCounter { get => ReadHere<ulong>(nameof(ulContextUpdateCounter)); set => WriteHere(nameof(ulContextUpdateCounter), value); }

        [Offset(8UL)]
        public int fAllowContextUpdate { get => ReadHere<int>(nameof(fAllowContextUpdate)); set => WriteHere(nameof(fAllowContextUpdate), value); }

        [Offset(12UL)]
        public int fEnableTrace { get => ReadHere<int>(nameof(fEnableTrace)); set => WriteHere(nameof(fEnableTrace), value); }

        [Offset(16UL)]
        public ulong EtwHandle { get => ReadHere<ulong>(nameof(EtwHandle)); set => WriteHere(nameof(EtwHandle), value); }

        public tagSWITCHContextAttribute(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<tagSWITCHContextAttribute>();
        }
    }
}