using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSR_CAPABILITIES")]
    public sealed class KsrCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public uint PerennialDatabase { get => ReadHere<uint>(nameof(PerennialDatabase)); set => WriteHere(nameof(PerennialDatabase), value); }

        [Offset(0UL)]
        public uint SkipSubAllocator { get => ReadHere<uint>(nameof(SkipSubAllocator)); set => WriteHere(nameof(SkipSubAllocator), value); }

        [Offset(0UL)]
        public uint ExtendedNotifications { get => ReadHere<uint>(nameof(ExtendedNotifications)); set => WriteHere(nameof(ExtendedNotifications), value); }

        [Offset(0UL)]
        public uint Kseg0Vtl1Mappings64KBAligned { get => ReadHere<uint>(nameof(Kseg0Vtl1Mappings64KBAligned)); set => WriteHere(nameof(Kseg0Vtl1Mappings64KBAligned), value); }

        [Offset(0UL)]
        public uint Vtl1IsolatedDatabase { get => ReadHere<uint>(nameof(Vtl1IsolatedDatabase)); set => WriteHere(nameof(Vtl1IsolatedDatabase), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULong { get => ReadHere<uint>(nameof(AsULong)); set => WriteHere(nameof(AsULong), value); }

        public KsrCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsrCapabilities>();
        }
    }
}