using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_ACPI_NOTIFY")]
    public sealed class PepWorkAcpiNotify : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public uint NotifyCode { get => ReadHere<uint>(nameof(NotifyCode)); set => WriteHere(nameof(NotifyCode), value); }

        public PepWorkAcpiNotify(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkAcpiNotify>();
        }
    }
}