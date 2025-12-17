using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_TRANS_PTR")]
    public sealed class CmTransPtr : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LightWeight { get => ReadHere<ulong>(nameof(LightWeight)); set => WriteHere(nameof(LightWeight), value); }

        [Offset(0UL)]
        public IntPtr TransPtr { get => ReadHere<IntPtr>(nameof(TransPtr)); set => WriteHere(nameof(TransPtr), value); }

        public CmTransPtr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmTransPtr>();
        }
    }
}