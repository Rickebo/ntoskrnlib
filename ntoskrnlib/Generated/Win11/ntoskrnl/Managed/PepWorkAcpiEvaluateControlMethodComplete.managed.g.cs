using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE")]
    public sealed class PepWorkAcpiEvaluateControlMethodComplete : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public uint CompletionFlags { get => ReadHere<uint>(nameof(CompletionFlags)); set => WriteHere(nameof(CompletionFlags), value); }

        [Offset(12UL)]
        public int MethodStatus { get => ReadHere<int>(nameof(MethodStatus)); set => WriteHere(nameof(MethodStatus), value); }

        [Offset(16UL)]
        public IntPtr CompletionContext { get => ReadHere<IntPtr>(nameof(CompletionContext)); set => WriteHere(nameof(CompletionContext), value); }

        [Offset(24UL)]
        public ulong OutputArgumentSize { get => ReadHere<ulong>(nameof(OutputArgumentSize)); set => WriteHere(nameof(OutputArgumentSize), value); }

        [Offset(32UL)]
        public IntPtr OutputArguments { get => ReadHere<IntPtr>(nameof(OutputArguments)); set => WriteHere(nameof(OutputArguments), value); }

        public PepWorkAcpiEvaluateControlMethodComplete(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkAcpiEvaluateControlMethodComplete>();
        }
    }
}