using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RH_OP_CONTEXT")]
    public sealed class RhOpContext : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr OplockRequestIrp { get => ReadHere<IntPtr>(nameof(OplockRequestIrp)); set => WriteHere(nameof(OplockRequestIrp), value); }

        [Offset(24UL)]
        public IntPtr OplockRequestFileObject { get => ReadHere<IntPtr>(nameof(OplockRequestFileObject)); set => WriteHere(nameof(OplockRequestFileObject), value); }

        [Offset(32UL)]
        public IntPtr OplockRequestProcess { get => ReadHere<IntPtr>(nameof(OplockRequestProcess)); set => WriteHere(nameof(OplockRequestProcess), value); }

        [Offset(40UL)]
        public IntPtr OplockOwnerThread { get => ReadHere<IntPtr>(nameof(OplockOwnerThread)); set => WriteHere(nameof(OplockOwnerThread), value); }

        [Offset(48UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(56UL)]
        public ListEntry AtomicLinks { get => ReadStructure<ListEntry>(nameof(AtomicLinks)); set => WriteStructure(nameof(AtomicLinks), value); }

        [Offset(72UL)]
        public OplockTelemetry TelemetryData { get => ReadStructure<OplockTelemetry>(nameof(TelemetryData)); set => WriteStructure(nameof(TelemetryData), value); }

        [Offset(88UL)]
        public IntPtr AckTimeout { get => ReadHere<IntPtr>(nameof(AckTimeout)); set => WriteHere(nameof(AckTimeout), value); }

        public RhOpContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RhOpContext>();
        }
    }
}