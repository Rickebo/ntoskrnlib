using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_COMPLETE_PERF_STATE")]
    public sealed class PepWorkCompletePerfState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public uint Component { get => ReadHere<uint>(nameof(Component)); set => WriteHere(nameof(Component), value); }

        [Offset(12UL)]
        public byte Succeeded { get => ReadHere<byte>(nameof(Succeeded)); set => WriteHere(nameof(Succeeded), value); }

        public PepWorkCompletePerfState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkCompletePerfState>();
        }
    }
}