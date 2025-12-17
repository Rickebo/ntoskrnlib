using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HIDDEN_PROCESSOR_POWER_INTERFACE")]
    public sealed class HiddenProcessorPowerInterface : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr ReadPerfMsr { get => ReadHere<IntPtr>(nameof(ReadPerfMsr)); set => WriteHere(nameof(ReadPerfMsr), value); }

        [Offset(16UL)]
        public IntPtr WritePerfMsr { get => ReadHere<IntPtr>(nameof(WritePerfMsr)); set => WriteHere(nameof(WritePerfMsr), value); }

        [Offset(24UL)]
        public IntPtr ReadPerfIoPort { get => ReadHere<IntPtr>(nameof(ReadPerfIoPort)); set => WriteHere(nameof(ReadPerfIoPort), value); }

        [Offset(32UL)]
        public IntPtr WritePerfIoPort { get => ReadHere<IntPtr>(nameof(WritePerfIoPort)); set => WriteHere(nameof(WritePerfIoPort), value); }

        public HiddenProcessorPowerInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HiddenProcessorPowerInterface>();
        }
    }
}