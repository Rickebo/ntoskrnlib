using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_DEVICE_IDLE")]
    public sealed class PepWorkDeviceIdle : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public byte IgnoreIdleTimeout { get => ReadHere<byte>(nameof(IgnoreIdleTimeout)); set => WriteHere(nameof(IgnoreIdleTimeout), value); }

        public PepWorkDeviceIdle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkDeviceIdle>();
        }
    }
}