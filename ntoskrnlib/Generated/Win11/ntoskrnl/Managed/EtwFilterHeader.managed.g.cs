using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_HEADER")]
    public sealed class EtwFilterHeader : DynamicStructure
    {
        [Offset(0UL)]
        public int FilterFlags { get => ReadHere<int>(nameof(FilterFlags)); set => WriteHere(nameof(FilterFlags), value); }

        [Offset(8UL)]
        public IntPtr PidFilter { get => ReadHere<IntPtr>(nameof(PidFilter)); set => WriteHere(nameof(PidFilter), value); }

        [Offset(16UL)]
        public IntPtr ExeFilter { get => ReadHere<IntPtr>(nameof(ExeFilter)); set => WriteHere(nameof(ExeFilter), value); }

        [Offset(24UL)]
        public IntPtr PkgIdFilter { get => ReadHere<IntPtr>(nameof(PkgIdFilter)); set => WriteHere(nameof(PkgIdFilter), value); }

        [Offset(32UL)]
        public IntPtr PkgAppIdFilter { get => ReadHere<IntPtr>(nameof(PkgAppIdFilter)); set => WriteHere(nameof(PkgAppIdFilter), value); }

        [Offset(40UL)]
        public IntPtr ContainerFilter { get => ReadHere<IntPtr>(nameof(ContainerFilter)); set => WriteHere(nameof(ContainerFilter), value); }

        [Offset(48UL)]
        public IntPtr StackWalkIdFilter { get => ReadHere<IntPtr>(nameof(StackWalkIdFilter)); set => WriteHere(nameof(StackWalkIdFilter), value); }

        [Offset(56UL)]
        public IntPtr StackWalkNameFilter { get => ReadHere<IntPtr>(nameof(StackWalkNameFilter)); set => WriteHere(nameof(StackWalkNameFilter), value); }

        [Offset(64UL)]
        public IntPtr StackWalkLevelKwFilter { get => ReadHere<IntPtr>(nameof(StackWalkLevelKwFilter)); set => WriteHere(nameof(StackWalkLevelKwFilter), value); }

        [Offset(72UL)]
        public IntPtr EventIdFilter { get => ReadHere<IntPtr>(nameof(EventIdFilter)); set => WriteHere(nameof(EventIdFilter), value); }

        [Offset(80UL)]
        public IntPtr PayloadFilter { get => ReadHere<IntPtr>(nameof(PayloadFilter)); set => WriteHere(nameof(PayloadFilter), value); }

        [Offset(88UL)]
        public IntPtr ProviderSideFilter { get => ReadHere<IntPtr>(nameof(ProviderSideFilter)); set => WriteHere(nameof(ProviderSideFilter), value); }

        [Offset(96UL)]
        public IntPtr EventNameFilter { get => ReadHere<IntPtr>(nameof(EventNameFilter)); set => WriteHere(nameof(EventNameFilter), value); }

        public EtwFilterHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwFilterHeader>();
        }
    }
}