using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ERESOURCE")]
    public sealed class Eresource : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry SystemResourcesList { get => ReadStructure<ListEntry>(nameof(SystemResourcesList)); set => WriteStructure(nameof(SystemResourcesList), value); }

        [Offset(16UL)]
        public IntPtr OwnerTable { get => ReadHere<IntPtr>(nameof(OwnerTable)); set => WriteHere(nameof(OwnerTable), value); }

        [Offset(24UL)]
        public short ActiveCount { get => ReadHere<short>(nameof(ActiveCount)); set => WriteHere(nameof(ActiveCount), value); }

        [Offset(26UL)]
        public ushort Flag { get => ReadHere<ushort>(nameof(Flag)); set => WriteHere(nameof(Flag), value); }

        [Offset(26UL)]
        public byte ReservedLowFlags { get => ReadHere<byte>(nameof(ReservedLowFlags)); set => WriteHere(nameof(ReservedLowFlags), value); }

        [Offset(27UL)]
        public byte WaiterPriority { get => ReadHere<byte>(nameof(WaiterPriority)); set => WriteHere(nameof(WaiterPriority), value); }

        [Offset(32UL)]
        public IntPtr SharedWaiters { get => ReadHere<IntPtr>(nameof(SharedWaiters)); set => WriteHere(nameof(SharedWaiters), value); }

        [Offset(40UL)]
        public IntPtr ExclusiveWaiters { get => ReadHere<IntPtr>(nameof(ExclusiveWaiters)); set => WriteHere(nameof(ExclusiveWaiters), value); }

        [Offset(48UL)]
        public OwnerEntry OwnerEntry { get => ReadStructure<OwnerEntry>(nameof(OwnerEntry)); set => WriteStructure(nameof(OwnerEntry), value); }

        [Offset(64UL)]
        public uint ActiveEntries { get => ReadHere<uint>(nameof(ActiveEntries)); set => WriteHere(nameof(ActiveEntries), value); }

        [Offset(68UL)]
        public uint ContentionCount { get => ReadHere<uint>(nameof(ContentionCount)); set => WriteHere(nameof(ContentionCount), value); }

        [Offset(72UL)]
        public uint NumberOfSharedWaiters { get => ReadHere<uint>(nameof(NumberOfSharedWaiters)); set => WriteHere(nameof(NumberOfSharedWaiters), value); }

        [Offset(76UL)]
        public uint NumberOfExclusiveWaiters { get => ReadHere<uint>(nameof(NumberOfExclusiveWaiters)); set => WriteHere(nameof(NumberOfExclusiveWaiters), value); }

        [Offset(80UL)]
        public sbyte MiscFlags { get => ReadHere<sbyte>(nameof(MiscFlags)); set => WriteHere(nameof(MiscFlags), value); }

        [Offset(81UL)]
        [Length(3)]
        public DynamicArray Reserved1 { get => ReadStructure<DynamicArray>(nameof(Reserved1)); set => WriteStructure(nameof(Reserved1), value); }

        [Offset(84UL)]
        public uint ResourceTimeoutCount { get => ReadHere<uint>(nameof(ResourceTimeoutCount)); set => WriteHere(nameof(ResourceTimeoutCount), value); }

        [Offset(88UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(88UL)]
        public ulong CreatorBackTraceIndex { get => ReadHere<ulong>(nameof(CreatorBackTraceIndex)); set => WriteHere(nameof(CreatorBackTraceIndex), value); }

        [Offset(96UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        public Eresource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Eresource>();
        }
    }
}