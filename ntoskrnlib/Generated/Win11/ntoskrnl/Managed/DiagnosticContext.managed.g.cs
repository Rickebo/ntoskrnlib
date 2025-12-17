using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DIAGNOSTIC_CONTEXT")]
    public sealed class DiagnosticContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint CallerType { get => ReadHere<uint>(nameof(CallerType)); set => WriteHere(nameof(CallerType), value); }

        [Offset(8UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(16UL)]
        public UnicodeString ProcessImageName { get => ReadStructure<UnicodeString>(nameof(ProcessImageName)); set => WriteStructure(nameof(ProcessImageName), value); }

        [Offset(32UL)]
        public uint ProcessId { get => ReadHere<uint>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(36UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(40UL)]
        public uint ServiceTag { get => ReadHere<uint>(nameof(ServiceTag)); set => WriteHere(nameof(ServiceTag), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(48UL)]
        public ulong ReasonSize { get => ReadHere<ulong>(nameof(ReasonSize)); set => WriteHere(nameof(ReasonSize), value); }

        public DiagnosticContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DiagnosticContext>();
        }
    }
}