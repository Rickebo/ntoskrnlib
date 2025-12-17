using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_NLS_STATE")]
    public sealed class RtlNlsState : DynamicStructure
    {
        [Offset(0UL)]
        public Cptableinfo DefaultAcpTableInfo { get => ReadStructure<Cptableinfo>(nameof(DefaultAcpTableInfo)); set => WriteStructure(nameof(DefaultAcpTableInfo), value); }

        [Offset(64UL)]
        public Cptableinfo DefaultOemTableInfo { get => ReadStructure<Cptableinfo>(nameof(DefaultOemTableInfo)); set => WriteStructure(nameof(DefaultOemTableInfo), value); }

        [Offset(128UL)]
        public IntPtr ActiveCodePageData { get => ReadHere<IntPtr>(nameof(ActiveCodePageData)); set => WriteHere(nameof(ActiveCodePageData), value); }

        [Offset(136UL)]
        public IntPtr OemCodePageData { get => ReadHere<IntPtr>(nameof(OemCodePageData)); set => WriteHere(nameof(OemCodePageData), value); }

        [Offset(144UL)]
        public IntPtr LeadByteInfo { get => ReadHere<IntPtr>(nameof(LeadByteInfo)); set => WriteHere(nameof(LeadByteInfo), value); }

        [Offset(152UL)]
        public IntPtr OemLeadByteInfo { get => ReadHere<IntPtr>(nameof(OemLeadByteInfo)); set => WriteHere(nameof(OemLeadByteInfo), value); }

        [Offset(160UL)]
        public IntPtr CaseMappingData { get => ReadHere<IntPtr>(nameof(CaseMappingData)); set => WriteHere(nameof(CaseMappingData), value); }

        [Offset(168UL)]
        public IntPtr UnicodeUpcaseTable844 { get => ReadHere<IntPtr>(nameof(UnicodeUpcaseTable844)); set => WriteHere(nameof(UnicodeUpcaseTable844), value); }

        [Offset(176UL)]
        public IntPtr UnicodeLowercaseTable844 { get => ReadHere<IntPtr>(nameof(UnicodeLowercaseTable844)); set => WriteHere(nameof(UnicodeLowercaseTable844), value); }

        public RtlNlsState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlNlsState>();
        }
    }
}