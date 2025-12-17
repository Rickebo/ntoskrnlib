using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSECURE_FAULT_INFORMATION")]
    public sealed class KsecureFaultInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ulong FaultCode { get => ReadHere<ulong>(nameof(FaultCode)); set => WriteHere(nameof(FaultCode), value); }

        [Offset(8UL)]
        public ulong FaultVa { get => ReadHere<ulong>(nameof(FaultVa)); set => WriteHere(nameof(FaultVa), value); }

        [Offset(16UL)]
        public ulong FaultPa { get => ReadHere<ulong>(nameof(FaultPa)); set => WriteHere(nameof(FaultPa), value); }

        public KsecureFaultInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsecureFaultInformation>();
        }
    }
}