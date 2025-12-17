using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SEP_RM_LSA_CONNECTION_STATE")]
    public sealed class SepRmLsaConnectionState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LsaProcessHandle { get => ReadHere<IntPtr>(nameof(LsaProcessHandle)); set => WriteHere(nameof(LsaProcessHandle), value); }

        [Offset(8UL)]
        public IntPtr LsaCommandPortHandle { get => ReadHere<IntPtr>(nameof(LsaCommandPortHandle)); set => WriteHere(nameof(LsaCommandPortHandle), value); }

        [Offset(16UL)]
        public IntPtr SepRmThreadHandle { get => ReadHere<IntPtr>(nameof(SepRmThreadHandle)); set => WriteHere(nameof(SepRmThreadHandle), value); }

        [Offset(24UL)]
        public IntPtr RmCommandPortHandle { get => ReadHere<IntPtr>(nameof(RmCommandPortHandle)); set => WriteHere(nameof(RmCommandPortHandle), value); }

        [Offset(32UL)]
        public IntPtr RmCommandServerPortHandle { get => ReadHere<IntPtr>(nameof(RmCommandServerPortHandle)); set => WriteHere(nameof(RmCommandServerPortHandle), value); }

        [Offset(40UL)]
        public byte LsaCommandPortActive { get => ReadHere<byte>(nameof(LsaCommandPortActive)); set => WriteHere(nameof(LsaCommandPortActive), value); }

        public SepRmLsaConnectionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepRmLsaConnectionState>();
        }
    }
}