using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HIVE_LIST_ENTRY")]
    public sealed class HiveListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FileName { get => ReadHere<IntPtr>(nameof(FileName)); set => WriteHere(nameof(FileName), value); }

        [Offset(8UL)]
        public IntPtr BaseName { get => ReadHere<IntPtr>(nameof(BaseName)); set => WriteHere(nameof(BaseName), value); }

        [Offset(16UL)]
        public IntPtr RegRootName { get => ReadHere<IntPtr>(nameof(RegRootName)); set => WriteHere(nameof(RegRootName), value); }

        [Offset(24UL)]
        public IntPtr CmHive { get => ReadHere<IntPtr>(nameof(CmHive)); set => WriteHere(nameof(CmHive), value); }

        [Offset(32UL)]
        public uint HHiveFlags { get => ReadHere<uint>(nameof(HHiveFlags)); set => WriteHere(nameof(HHiveFlags), value); }

        [Offset(36UL)]
        public uint CmHiveFlags { get => ReadHere<uint>(nameof(CmHiveFlags)); set => WriteHere(nameof(CmHiveFlags), value); }

        [Offset(40UL)]
        public uint CmKcbCacheSize { get => ReadHere<uint>(nameof(CmKcbCacheSize)); set => WriteHere(nameof(CmKcbCacheSize), value); }

        [Offset(48UL)]
        public IntPtr CmHive2 { get => ReadHere<IntPtr>(nameof(CmHive2)); set => WriteHere(nameof(CmHive2), value); }

        [Offset(56UL)]
        public byte HiveMounted { get => ReadHere<byte>(nameof(HiveMounted)); set => WriteHere(nameof(HiveMounted), value); }

        [Offset(57UL)]
        public byte ThreadFinished { get => ReadHere<byte>(nameof(ThreadFinished)); set => WriteHere(nameof(ThreadFinished), value); }

        [Offset(58UL)]
        public byte ThreadStarted { get => ReadHere<byte>(nameof(ThreadStarted)); set => WriteHere(nameof(ThreadStarted), value); }

        [Offset(59UL)]
        public byte Allocate { get => ReadHere<byte>(nameof(Allocate)); set => WriteHere(nameof(Allocate), value); }

        [Offset(60UL)]
        public byte WinPERequired { get => ReadHere<byte>(nameof(WinPERequired)); set => WriteHere(nameof(WinPERequired), value); }

        [Offset(64UL)]
        public Kevent StartEvent { get => ReadStructure<Kevent>(nameof(StartEvent)); set => WriteStructure(nameof(StartEvent), value); }

        [Offset(88UL)]
        public Kevent FinishedEvent { get => ReadStructure<Kevent>(nameof(FinishedEvent)); set => WriteStructure(nameof(FinishedEvent), value); }

        [Offset(112UL)]
        public Kevent MountLock { get => ReadStructure<Kevent>(nameof(MountLock)); set => WriteStructure(nameof(MountLock), value); }

        [Offset(136UL)]
        public ExPushLock MountCallbackLock { get => ReadStructure<ExPushLock>(nameof(MountCallbackLock)); set => WriteStructure(nameof(MountCallbackLock), value); }

        [Offset(144UL)]
        public ExPushLock CallbackListLock { get => ReadStructure<ExPushLock>(nameof(CallbackListLock)); set => WriteStructure(nameof(CallbackListLock), value); }

        [Offset(152UL)]
        public ListEntry CallbackListHead { get => ReadStructure<ListEntry>(nameof(CallbackListHead)); set => WriteStructure(nameof(CallbackListHead), value); }

        [Offset(168UL)]
        public UnicodeString FilePath { get => ReadStructure<UnicodeString>(nameof(FilePath)); set => WriteStructure(nameof(FilePath), value); }

        public HiveListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HiveListEntry>();
        }
    }
}