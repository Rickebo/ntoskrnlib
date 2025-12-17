using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PROCESS_STATE")]
    public sealed class MiProcessState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SystemDllBase { get => ReadHere<IntPtr>(nameof(SystemDllBase)); set => WriteHere(nameof(SystemDllBase), value); }

        [Offset(8UL)]
        public uint ColorSeed { get => ReadHere<uint>(nameof(ColorSeed)); set => WriteHere(nameof(ColorSeed), value); }

        [Offset(12UL)]
        public int RotatingUniprocessorNumber { get => ReadHere<int>(nameof(RotatingUniprocessorNumber)); set => WriteHere(nameof(RotatingUniprocessorNumber), value); }

        [Offset(16UL)]
        public LargeInteger CriticalSectionTimeout { get => ReadStructure<LargeInteger>(nameof(CriticalSectionTimeout)); set => WriteStructure(nameof(CriticalSectionTimeout), value); }

        [Offset(24UL)]
        public ListEntry ProcessList { get => ReadStructure<ListEntry>(nameof(ProcessList)); set => WriteStructure(nameof(ProcessList), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray SharedUserDataPte { get => ReadStructure<DynamicArray>(nameof(SharedUserDataPte)); set => WriteStructure(nameof(SharedUserDataPte), value); }

        [Offset(56UL)]
        public IntPtr HypervisorSharedVa { get => ReadHere<IntPtr>(nameof(HypervisorSharedVa)); set => WriteHere(nameof(HypervisorSharedVa), value); }

        [Offset(64UL)]
        public ulong VadSecureCookie { get => ReadHere<ulong>(nameof(VadSecureCookie)); set => WriteHere(nameof(VadSecureCookie), value); }

        [Offset(72UL)]
        public IntPtr NativeCfgBitmapPreferredAddress { get => ReadHere<IntPtr>(nameof(NativeCfgBitmapPreferredAddress)); set => WriteHere(nameof(NativeCfgBitmapPreferredAddress), value); }

        [Offset(80UL)]
        public IntPtr EcBitmapPreferredAddress { get => ReadHere<IntPtr>(nameof(EcBitmapPreferredAddress)); set => WriteHere(nameof(EcBitmapPreferredAddress), value); }

        public MiProcessState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiProcessState>();
        }
    }
}