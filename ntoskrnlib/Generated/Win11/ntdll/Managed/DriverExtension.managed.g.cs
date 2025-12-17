using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DRIVER_EXTENSION")]
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

        [Offset(40UL)]
        public IntPtr ClientDriverExtension { get => ReadHere<IntPtr>(nameof(ClientDriverExtension)); set => WriteHere(nameof(ClientDriverExtension), value); }

        [Offset(48UL)]
        public IntPtr FsFilterCallbacks { get => ReadHere<IntPtr>(nameof(FsFilterCallbacks)); set => WriteHere(nameof(FsFilterCallbacks), value); }

        [Offset(56UL)]
        public IntPtr KseCallbacks { get => ReadHere<IntPtr>(nameof(KseCallbacks)); set => WriteHere(nameof(KseCallbacks), value); }

        [Offset(64UL)]
        public IntPtr DvCallbacks { get => ReadHere<IntPtr>(nameof(DvCallbacks)); set => WriteHere(nameof(DvCallbacks), value); }

        [Offset(72UL)]
        public IntPtr VerifierContext { get => ReadHere<IntPtr>(nameof(VerifierContext)); set => WriteHere(nameof(VerifierContext), value); }

        [Offset(80UL)]
        public IntPtr DriverProxyExtension { get => ReadHere<IntPtr>(nameof(DriverProxyExtension)); set => WriteHere(nameof(DriverProxyExtension), value); }

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