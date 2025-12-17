using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CRITICAL_PROCESS_EXCEPTION_DATA")]
    public sealed class CriticalProcessExceptionData : DynamicStructure
    {
        [Offset(0UL)]
        public Guid ReportId { get => ReadStructure<Guid>(nameof(ReportId)); set => WriteStructure(nameof(ReportId), value); }

        [Offset(16UL)]
        public UnicodeString ModuleName { get => ReadStructure<UnicodeString>(nameof(ModuleName)); set => WriteStructure(nameof(ModuleName), value); }

        [Offset(32UL)]
        public uint ModuleTimestamp { get => ReadHere<uint>(nameof(ModuleTimestamp)); set => WriteHere(nameof(ModuleTimestamp), value); }

        [Offset(36UL)]
        public uint ModuleSize { get => ReadHere<uint>(nameof(ModuleSize)); set => WriteHere(nameof(ModuleSize), value); }

        [Offset(40UL)]
        public ulong Offset { get => ReadHere<ulong>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        public CriticalProcessExceptionData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CriticalProcessExceptionData>();
        }
    }
}