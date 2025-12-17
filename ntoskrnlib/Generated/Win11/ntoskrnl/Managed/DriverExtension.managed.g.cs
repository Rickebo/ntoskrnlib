using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DRIVER_EXTENSION")]
    public sealed class DriverExtension : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DriverObject { get => ReadHere<IntPtr>(nameof(DriverObject)); set => WriteHere(nameof(DriverObject), value); }

        [Offset(8UL)]
        public IntPtr AddDevice { get => ReadHere<IntPtr>(nameof(AddDevice)); set => WriteHere(nameof(AddDevice), value); }

        [Offset(16UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(24UL)]
        public UnicodeString ServiceKeyName { get => ReadStructure<UnicodeString>(nameof(ServiceKeyName)); set => WriteStructure(nameof(ServiceKeyName), value); }

        public DriverExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DriverExtension>();
        }
    }
}