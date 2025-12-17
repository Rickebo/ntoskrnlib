using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_ACTION_REQUEST_ARGUMENT")]
    public sealed class PnpDeviceActionRequestArgument : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PdcActivatorHandle { get => ReadHere<IntPtr>(nameof(PdcActivatorHandle)); set => WriteHere(nameof(PdcActivatorHandle), value); }

        [Offset(8UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public PnpDeviceActionRequestArgument(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceActionRequestArgument>();
        }
    }
}