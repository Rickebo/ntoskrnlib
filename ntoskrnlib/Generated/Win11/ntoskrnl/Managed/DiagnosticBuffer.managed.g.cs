using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DIAGNOSTIC_BUFFER")]
    public sealed class DiagnosticBuffer : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint CallerType { get => ReadHere<uint>(nameof(CallerType)); set => WriteHere(nameof(CallerType), value); }

        [Offset(16UL)]
        public ulong ProcessImageNameOffset { get => ReadHere<ulong>(nameof(ProcessImageNameOffset)); set => WriteHere(nameof(ProcessImageNameOffset), value); }

        [Offset(24UL)]
        public uint ProcessId { get => ReadHere<uint>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(28UL)]
        public uint ServiceTag { get => ReadHere<uint>(nameof(ServiceTag)); set => WriteHere(nameof(ServiceTag), value); }

        [Offset(16UL)]
        public ulong DeviceDescriptionOffset { get => ReadHere<ulong>(nameof(DeviceDescriptionOffset)); set => WriteHere(nameof(DeviceDescriptionOffset), value); }

        [Offset(24UL)]
        public ulong DevicePathOffset { get => ReadHere<ulong>(nameof(DevicePathOffset)); set => WriteHere(nameof(DevicePathOffset), value); }

        [Offset(32UL)]
        public ulong ReasonOffset { get => ReadHere<ulong>(nameof(ReasonOffset)); set => WriteHere(nameof(ReasonOffset), value); }

        public DiagnosticBuffer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DiagnosticBuffer>();
        }
    }
}