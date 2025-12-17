using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FILE_OBJECT")]
    public sealed class FileObject : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public IntPtr Vpb { get => ReadHere<IntPtr>(nameof(Vpb)); set => WriteHere(nameof(Vpb), value); }

        [Offset(24UL)]
        public IntPtr FsContext { get => ReadHere<IntPtr>(nameof(FsContext)); set => WriteHere(nameof(FsContext), value); }

        [Offset(32UL)]
        public IntPtr FsContext2 { get => ReadHere<IntPtr>(nameof(FsContext2)); set => WriteHere(nameof(FsContext2), value); }

        [Offset(40UL)]
        public IntPtr SectionObjectPointer { get => ReadHere<IntPtr>(nameof(SectionObjectPointer)); set => WriteHere(nameof(SectionObjectPointer), value); }

        [Offset(48UL)]
        public IntPtr PrivateCacheMap { get => ReadHere<IntPtr>(nameof(PrivateCacheMap)); set => WriteHere(nameof(PrivateCacheMap), value); }

        [Offset(56UL)]
        public int FinalStatus { get => ReadHere<int>(nameof(FinalStatus)); set => WriteHere(nameof(FinalStatus), value); }

        [Offset(64UL)]
        public IntPtr RelatedFileObject { get => ReadHere<IntPtr>(nameof(RelatedFileObject)); set => WriteHere(nameof(RelatedFileObject), value); }

        [Offset(72UL)]
        public byte LockOperation { get => ReadHere<byte>(nameof(LockOperation)); set => WriteHere(nameof(LockOperation), value); }

        [Offset(73UL)]
        public byte DeletePending { get => ReadHere<byte>(nameof(DeletePending)); set => WriteHere(nameof(DeletePending), value); }

        [Offset(74UL)]
        public byte ReadAccess { get => ReadHere<byte>(nameof(ReadAccess)); set => WriteHere(nameof(ReadAccess), value); }

        [Offset(75UL)]
        public byte WriteAccess { get => ReadHere<byte>(nameof(WriteAccess)); set => WriteHere(nameof(WriteAccess), value); }

        [Offset(76UL)]
        public byte DeleteAccess { get => ReadHere<byte>(nameof(DeleteAccess)); set => WriteHere(nameof(DeleteAccess), value); }

        [Offset(77UL)]
        public byte SharedRead { get => ReadHere<byte>(nameof(SharedRead)); set => WriteHere(nameof(SharedRead), value); }

        [Offset(78UL)]
        public byte SharedWrite { get => ReadHere<byte>(nameof(SharedWrite)); set => WriteHere(nameof(SharedWrite), value); }

        [Offset(79UL)]
        public byte SharedDelete { get => ReadHere<byte>(nameof(SharedDelete)); set => WriteHere(nameof(SharedDelete), value); }

        [Offset(80UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(88UL)]
        public UnicodeString FileName { get => ReadStructure<UnicodeString>(nameof(FileName)); set => WriteStructure(nameof(FileName), value); }

        [Offset(104UL)]
        public LargeInteger CurrentByteOffset { get => ReadStructure<LargeInteger>(nameof(CurrentByteOffset)); set => WriteStructure(nameof(CurrentByteOffset), value); }

        [Offset(112UL)]
        public uint Waiters { get => ReadHere<uint>(nameof(Waiters)); set => WriteHere(nameof(Waiters), value); }

        [Offset(116UL)]
        public uint Busy { get => ReadHere<uint>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(120UL)]
        public IntPtr LastLock { get => ReadHere<IntPtr>(nameof(LastLock)); set => WriteHere(nameof(LastLock), value); }

        [Offset(128UL)]
        public Kevent Lock { get => ReadStructure<Kevent>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(152UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(176UL)]
        public IntPtr CompletionContext { get => ReadHere<IntPtr>(nameof(CompletionContext)); set => WriteHere(nameof(CompletionContext), value); }

        [Offset(184UL)]
        public ulong IrpListLock { get => ReadHere<ulong>(nameof(IrpListLock)); set => WriteHere(nameof(IrpListLock), value); }

        [Offset(192UL)]
        public ListEntry IrpList { get => ReadStructure<ListEntry>(nameof(IrpList)); set => WriteStructure(nameof(IrpList), value); }

        [Offset(208UL)]
        public IntPtr FileObjectExtension { get => ReadHere<IntPtr>(nameof(FileObjectExtension)); set => WriteHere(nameof(FileObjectExtension), value); }

        public FileObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileObject>();
        }
    }
}