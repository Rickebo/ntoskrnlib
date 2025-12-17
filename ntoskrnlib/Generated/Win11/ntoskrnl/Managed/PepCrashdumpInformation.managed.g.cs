using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_CRASHDUMP_INFORMATION")]
    public sealed class PepCrashdumpInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public IntPtr DeviceContext { get => ReadHere<IntPtr>(nameof(DeviceContext)); set => WriteHere(nameof(DeviceContext), value); }

        public PepCrashdumpInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepCrashdumpInformation>();
        }
    }
}