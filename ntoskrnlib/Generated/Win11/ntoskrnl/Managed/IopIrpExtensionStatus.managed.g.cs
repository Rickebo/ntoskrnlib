using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOP_IRP_EXTENSION_STATUS")]
    public sealed class IopIrpExtensionStatus : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public uint ActivityId { get => ReadHere<uint>(nameof(ActivityId)); set => WriteHere(nameof(ActivityId), value); }

        [Offset(8UL)]
        public uint IoTracking { get => ReadHere<uint>(nameof(IoTracking)); set => WriteHere(nameof(IoTracking), value); }

        public IopIrpExtensionStatus(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopIrpExtensionStatus>();
        }
    }
}