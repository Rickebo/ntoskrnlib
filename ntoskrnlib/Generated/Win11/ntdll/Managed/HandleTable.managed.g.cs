using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TABLE")]
    public sealed class HandleTable : DynamicStructure
    {
        [Offset(0UL)]
        public uint NextHandleNeedingPool { get => ReadHere<uint>(nameof(NextHandleNeedingPool)); set => WriteHere(nameof(NextHandleNeedingPool), value); }

        [Offset(4UL)]
        public int ExtraInfoPages { get => ReadHere<int>(nameof(ExtraInfoPages)); set => WriteHere(nameof(ExtraInfoPages), value); }

        [Offset(8UL)]
        public ulong TableCode { get => ReadHere<ulong>(nameof(TableCode)); set => WriteHere(nameof(TableCode), value); }

        [Offset(16UL)]
        public IntPtr QuotaProcess { get => ReadHere<IntPtr>(nameof(QuotaProcess)); set => WriteHere(nameof(QuotaProcess), value); }

        [Offset(24UL)]
        public ListEntry HandleTableList { get => ReadStructure<ListEntry>(nameof(HandleTableList)); set => WriteStructure(nameof(HandleTableList), value); }

        [Offset(40UL)]
        public uint UniqueProcessId { get => ReadHere<uint>(nameof(UniqueProcessId)); set => WriteHere(nameof(UniqueProcessId), value); }

        [Offset(44UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(44UL)]
        public byte StrictFIFO { get => ReadHere<byte>(nameof(StrictFIFO)); set => WriteHere(nameof(StrictFIFO), value); }

        [Offset(44UL)]
        public byte EnableHandleExceptions { get => ReadHere<byte>(nameof(EnableHandleExceptions)); set => WriteHere(nameof(EnableHandleExceptions), value); }

        [Offset(44UL)]
        public byte Rundown { get => ReadHere<byte>(nameof(Rundown)); set => WriteHere(nameof(Rundown), value); }

        [Offset(44UL)]
        public byte Duplicated { get => ReadHere<byte>(nameof(Duplicated)); set => WriteHere(nameof(Duplicated), value); }

        [Offset(44UL)]
        public byte RaiseUMExceptionOnInvalidHandleClose { get => ReadHere<byte>(nameof(RaiseUMExceptionOnInvalidHandleClose)); set => WriteHere(nameof(RaiseUMExceptionOnInvalidHandleClose), value); }

        [Offset(48UL)]
        public ExPushLock HandleContentionEvent { get => ReadStructure<ExPushLock>(nameof(HandleContentionEvent)); set => WriteStructure(nameof(HandleContentionEvent), value); }

        [Offset(56UL)]
        public ExPushLock HandleTableLock { get => ReadStructure<ExPushLock>(nameof(HandleTableLock)); set => WriteStructure(nameof(HandleTableLock), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray FreeLists { get => ReadStructure<DynamicArray>(nameof(FreeLists)); set => WriteStructure(nameof(FreeLists), value); }

        [Offset(64UL)]
        [Length(32)]
        public DynamicArray ActualEntry { get => ReadStructure<DynamicArray>(nameof(ActualEntry)); set => WriteStructure(nameof(ActualEntry), value); }

        [Offset(96UL)]
        public IntPtr DebugInfo { get => ReadHere<IntPtr>(nameof(DebugInfo)); set => WriteHere(nameof(DebugInfo), value); }

        public HandleTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTable>();
        }
    }
}