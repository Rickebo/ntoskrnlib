using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_DP_REPLACE_PARAMETERS")]
    public sealed class HalDpReplaceParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public IntPtr TargetProcessors { get => ReadHere<IntPtr>(nameof(TargetProcessors)); set => WriteHere(nameof(TargetProcessors), value); }

        [Offset(16UL)]
        public IntPtr SpareProcessors { get => ReadHere<IntPtr>(nameof(SpareProcessors)); set => WriteHere(nameof(SpareProcessors), value); }

        public HalDpReplaceParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalDpReplaceParameters>();
        }
    }
}