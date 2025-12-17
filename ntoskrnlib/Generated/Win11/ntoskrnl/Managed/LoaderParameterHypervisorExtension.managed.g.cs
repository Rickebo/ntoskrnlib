using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_HYPERVISOR_EXTENSION")]
    public sealed class LoaderParameterHypervisorExtension : DynamicStructure
    {
        [Offset(0UL)]
        public uint InitialHypervisorCrashdumpAreaPageCount { get => ReadHere<uint>(nameof(InitialHypervisorCrashdumpAreaPageCount)); set => WriteHere(nameof(InitialHypervisorCrashdumpAreaPageCount), value); }

        [Offset(4UL)]
        public uint HypervisorCrashdumpAreaPageCount { get => ReadHere<uint>(nameof(HypervisorCrashdumpAreaPageCount)); set => WriteHere(nameof(HypervisorCrashdumpAreaPageCount), value); }

        [Offset(8UL)]
        public ulong InitialHypervisorCrashdumpAreaSpa { get => ReadHere<ulong>(nameof(InitialHypervisorCrashdumpAreaSpa)); set => WriteHere(nameof(InitialHypervisorCrashdumpAreaSpa), value); }

        [Offset(16UL)]
        public ulong HypervisorCrashdumpAreaSpa { get => ReadHere<ulong>(nameof(HypervisorCrashdumpAreaSpa)); set => WriteHere(nameof(HypervisorCrashdumpAreaSpa), value); }

        [Offset(24UL)]
        public ulong HypervisorLaunchStatus { get => ReadHere<ulong>(nameof(HypervisorLaunchStatus)); set => WriteHere(nameof(HypervisorLaunchStatus), value); }

        [Offset(32UL)]
        public ulong HypervisorLaunchStatusArg1 { get => ReadHere<ulong>(nameof(HypervisorLaunchStatusArg1)); set => WriteHere(nameof(HypervisorLaunchStatusArg1), value); }

        [Offset(40UL)]
        public ulong HypervisorLaunchStatusArg2 { get => ReadHere<ulong>(nameof(HypervisorLaunchStatusArg2)); set => WriteHere(nameof(HypervisorLaunchStatusArg2), value); }

        [Offset(48UL)]
        public ulong HypervisorLaunchStatusArg3 { get => ReadHere<ulong>(nameof(HypervisorLaunchStatusArg3)); set => WriteHere(nameof(HypervisorLaunchStatusArg3), value); }

        [Offset(56UL)]
        public ulong HypervisorLaunchStatusArg4 { get => ReadHere<ulong>(nameof(HypervisorLaunchStatusArg4)); set => WriteHere(nameof(HypervisorLaunchStatusArg4), value); }

        [Offset(40UL)]
        public IntPtr RangeArray { get => ReadHere<IntPtr>(nameof(RangeArray)); set => WriteHere(nameof(RangeArray), value); }

        [Offset(48UL)]
        public uint RangeCount { get => ReadHere<uint>(nameof(RangeCount)); set => WriteHere(nameof(RangeCount), value); }

        public LoaderParameterHypervisorExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderParameterHypervisorExtension>();
        }
    }
}