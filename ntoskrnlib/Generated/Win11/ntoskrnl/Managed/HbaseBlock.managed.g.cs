using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HBASE_BLOCK")]
    public sealed class HbaseBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Sequence1 { get => ReadHere<uint>(nameof(Sequence1)); set => WriteHere(nameof(Sequence1), value); }

        [Offset(8UL)]
        public uint Sequence2 { get => ReadHere<uint>(nameof(Sequence2)); set => WriteHere(nameof(Sequence2), value); }

        [Offset(12UL)]
        public LargeInteger TimeStamp { get => ReadStructure<LargeInteger>(nameof(TimeStamp)); set => WriteStructure(nameof(TimeStamp), value); }

        [Offset(20UL)]
        public uint Major { get => ReadHere<uint>(nameof(Major)); set => WriteHere(nameof(Major), value); }

        [Offset(24UL)]
        public uint Minor { get => ReadHere<uint>(nameof(Minor)); set => WriteHere(nameof(Minor), value); }

        [Offset(28UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(32UL)]
        public uint Format { get => ReadHere<uint>(nameof(Format)); set => WriteHere(nameof(Format), value); }

        [Offset(36UL)]
        public uint RootCell { get => ReadHere<uint>(nameof(RootCell)); set => WriteHere(nameof(RootCell), value); }

        [Offset(40UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(44UL)]
        public uint Cluster { get => ReadHere<uint>(nameof(Cluster)); set => WriteHere(nameof(Cluster), value); }

        [Offset(48UL)]
        [Length(64)]
        public DynamicArray FileName { get => ReadStructure<DynamicArray>(nameof(FileName)); set => WriteStructure(nameof(FileName), value); }

        [Offset(112UL)]
        public Guid RmId { get => ReadStructure<Guid>(nameof(RmId)); set => WriteStructure(nameof(RmId), value); }

        [Offset(128UL)]
        public Guid LogId { get => ReadStructure<Guid>(nameof(LogId)); set => WriteStructure(nameof(LogId), value); }

        [Offset(144UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(148UL)]
        public Guid TmId { get => ReadStructure<Guid>(nameof(TmId)); set => WriteStructure(nameof(TmId), value); }

        [Offset(164UL)]
        public uint GuidSignature { get => ReadHere<uint>(nameof(GuidSignature)); set => WriteHere(nameof(GuidSignature), value); }

        [Offset(168UL)]
        public ulong LastReorganizeTime { get => ReadHere<ulong>(nameof(LastReorganizeTime)); set => WriteHere(nameof(LastReorganizeTime), value); }

        [Offset(176UL)]
        [Length(83)]
        public DynamicArray Reserved1 { get => ReadStructure<DynamicArray>(nameof(Reserved1)); set => WriteStructure(nameof(Reserved1), value); }

        [Offset(508UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(512UL)]
        [Length(882)]
        public DynamicArray Reserved2 { get => ReadStructure<DynamicArray>(nameof(Reserved2)); set => WriteStructure(nameof(Reserved2), value); }

        [Offset(4040UL)]
        public Guid ThawTmId { get => ReadStructure<Guid>(nameof(ThawTmId)); set => WriteStructure(nameof(ThawTmId), value); }

        [Offset(4056UL)]
        public Guid ThawRmId { get => ReadStructure<Guid>(nameof(ThawRmId)); set => WriteStructure(nameof(ThawRmId), value); }

        [Offset(4072UL)]
        public Guid ThawLogId { get => ReadStructure<Guid>(nameof(ThawLogId)); set => WriteStructure(nameof(ThawLogId), value); }

        [Offset(4088UL)]
        public uint BootType { get => ReadHere<uint>(nameof(BootType)); set => WriteHere(nameof(BootType), value); }

        [Offset(4092UL)]
        public uint BootRecover { get => ReadHere<uint>(nameof(BootRecover)); set => WriteHere(nameof(BootRecover), value); }

        public HbaseBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HbaseBlock>();
        }
    }
}