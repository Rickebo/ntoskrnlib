using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KLDR_DATA_TABLE_ENTRY")]
    public sealed class KldrDataTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry InLoadOrderLinks { get => ReadStructure<ListEntry>(nameof(InLoadOrderLinks)); set => WriteStructure(nameof(InLoadOrderLinks), value); }

        [Offset(16UL)]
        public IntPtr ExceptionTable { get => ReadHere<IntPtr>(nameof(ExceptionTable)); set => WriteHere(nameof(ExceptionTable), value); }

        [Offset(24UL)]
        public uint ExceptionTableSize { get => ReadHere<uint>(nameof(ExceptionTableSize)); set => WriteHere(nameof(ExceptionTableSize), value); }

        [Offset(32UL)]
        public IntPtr GpValue { get => ReadHere<IntPtr>(nameof(GpValue)); set => WriteHere(nameof(GpValue), value); }

        [Offset(40UL)]
        public IntPtr NonPagedDebugInfo { get => ReadHere<IntPtr>(nameof(NonPagedDebugInfo)); set => WriteHere(nameof(NonPagedDebugInfo), value); }

        [Offset(48UL)]
        public IntPtr DllBase { get => ReadHere<IntPtr>(nameof(DllBase)); set => WriteHere(nameof(DllBase), value); }

        [Offset(56UL)]
        public IntPtr EntryPoint { get => ReadHere<IntPtr>(nameof(EntryPoint)); set => WriteHere(nameof(EntryPoint), value); }

        [Offset(64UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(72UL)]
        public UnicodeString FullDllName { get => ReadStructure<UnicodeString>(nameof(FullDllName)); set => WriteStructure(nameof(FullDllName), value); }

        [Offset(88UL)]
        public UnicodeString BaseDllName { get => ReadStructure<UnicodeString>(nameof(BaseDllName)); set => WriteStructure(nameof(BaseDllName), value); }

        [Offset(104UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(108UL)]
        public ushort LoadCount { get => ReadHere<ushort>(nameof(LoadCount)); set => WriteHere(nameof(LoadCount), value); }

        [Offset(110UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(112UL)]
        public IntPtr SectionPointer { get => ReadHere<IntPtr>(nameof(SectionPointer)); set => WriteHere(nameof(SectionPointer), value); }

        [Offset(120UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(124UL)]
        public uint CoverageSectionSize { get => ReadHere<uint>(nameof(CoverageSectionSize)); set => WriteHere(nameof(CoverageSectionSize), value); }

        [Offset(128UL)]
        public IntPtr CoverageSection { get => ReadHere<IntPtr>(nameof(CoverageSection)); set => WriteHere(nameof(CoverageSection), value); }

        [Offset(136UL)]
        public IntPtr LoadedImports { get => ReadHere<IntPtr>(nameof(LoadedImports)); set => WriteHere(nameof(LoadedImports), value); }

        [Offset(144UL)]
        public IntPtr Spare { get => ReadHere<IntPtr>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(144UL)]
        public IntPtr NtDataTableEntry { get => ReadHere<IntPtr>(nameof(NtDataTableEntry)); set => WriteHere(nameof(NtDataTableEntry), value); }

        [Offset(152UL)]
        public uint SizeOfImageNotRounded { get => ReadHere<uint>(nameof(SizeOfImageNotRounded)); set => WriteHere(nameof(SizeOfImageNotRounded), value); }

        [Offset(156UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        public KldrDataTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KldrDataTableEntry>();
        }
    }
}