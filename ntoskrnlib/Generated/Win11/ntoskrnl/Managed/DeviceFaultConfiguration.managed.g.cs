using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_FAULT_CONFIGURATION")]
    public sealed class DeviceFaultConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FaultHandler { get => ReadHere<IntPtr>(nameof(FaultHandler)); set => WriteHere(nameof(FaultHandler), value); }

        [Offset(8UL)]
        public IntPtr FaultContext { get => ReadHere<IntPtr>(nameof(FaultContext)); set => WriteHere(nameof(FaultContext), value); }

        public DeviceFaultConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceFaultConfiguration>();
        }
    }
}