using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_HEADER_FLAGS")]
    public sealed class WheaErrorRecordHeaderFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Recovered { get => ReadHere<uint>(nameof(Recovered)); set => WriteHere(nameof(Recovered), value); }

        [Offset(0UL)]
        public uint PreviousError { get => ReadHere<uint>(nameof(PreviousError)); set => WriteHere(nameof(PreviousError), value); }

        [Offset(0UL)]
        public uint Simulated { get => ReadHere<uint>(nameof(Simulated)); set => WriteHere(nameof(Simulated), value); }

        [Offset(0UL)]
        public uint DeviceDriver { get => ReadHere<uint>(nameof(DeviceDriver)); set => WriteHere(nameof(DeviceDriver), value); }

        [Offset(0UL)]
        public uint CriticalEvent { get => ReadHere<uint>(nameof(CriticalEvent)); set => WriteHere(nameof(CriticalEvent), value); }

        [Offset(0UL)]
        public uint PersistPfn { get => ReadHere<uint>(nameof(PersistPfn)); set => WriteHere(nameof(PersistPfn), value); }

        [Offset(0UL)]
        public uint SectionsTruncated { get => ReadHere<uint>(nameof(SectionsTruncated)); set => WriteHere(nameof(SectionsTruncated), value); }

        [Offset(0UL)]
        public uint RecoveryInProgress { get => ReadHere<uint>(nameof(RecoveryInProgress)); set => WriteHere(nameof(RecoveryInProgress), value); }

        [Offset(0UL)]
        public uint Throttle { get => ReadHere<uint>(nameof(Throttle)); set => WriteHere(nameof(Throttle), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheaErrorRecordHeaderFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordHeaderFlags>();
        }
    }
}