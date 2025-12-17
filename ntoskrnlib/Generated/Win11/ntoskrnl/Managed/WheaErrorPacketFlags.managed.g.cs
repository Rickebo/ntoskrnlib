using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_PACKET_FLAGS")]
    public sealed class WheaErrorPacketFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint PreviousError { get => ReadHere<uint>(nameof(PreviousError)); set => WriteHere(nameof(PreviousError), value); }

        [Offset(0UL)]
        public uint CriticalEvent { get => ReadHere<uint>(nameof(CriticalEvent)); set => WriteHere(nameof(CriticalEvent), value); }

        [Offset(0UL)]
        public uint HypervisorError { get => ReadHere<uint>(nameof(HypervisorError)); set => WriteHere(nameof(HypervisorError), value); }

        [Offset(0UL)]
        public uint Simulated { get => ReadHere<uint>(nameof(Simulated)); set => WriteHere(nameof(Simulated), value); }

        [Offset(0UL)]
        public uint PlatformPfaControl { get => ReadHere<uint>(nameof(PlatformPfaControl)); set => WriteHere(nameof(PlatformPfaControl), value); }

        [Offset(0UL)]
        public uint PlatformDirectedOffline { get => ReadHere<uint>(nameof(PlatformDirectedOffline)); set => WriteHere(nameof(PlatformDirectedOffline), value); }

        [Offset(0UL)]
        public uint AddressTranslationRequired { get => ReadHere<uint>(nameof(AddressTranslationRequired)); set => WriteHere(nameof(AddressTranslationRequired), value); }

        [Offset(0UL)]
        public uint AddressTranslationCompleted { get => ReadHere<uint>(nameof(AddressTranslationCompleted)); set => WriteHere(nameof(AddressTranslationCompleted), value); }

        [Offset(0UL)]
        public uint RecoveryOptional { get => ReadHere<uint>(nameof(RecoveryOptional)); set => WriteHere(nameof(RecoveryOptional), value); }

        [Offset(0UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheaErrorPacketFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorPacketFlags>();
        }
    }
}