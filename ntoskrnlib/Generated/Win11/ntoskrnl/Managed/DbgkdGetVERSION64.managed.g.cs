using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_VERSION64")]
    public sealed class DbgkdGetVERSION64 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(2UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(4UL)]
        public byte ProtocolVersion { get => ReadHere<byte>(nameof(ProtocolVersion)); set => WriteHere(nameof(ProtocolVersion), value); }

        [Offset(5UL)]
        public byte KdSecondaryVersion { get => ReadHere<byte>(nameof(KdSecondaryVersion)); set => WriteHere(nameof(KdSecondaryVersion), value); }

        [Offset(6UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public ushort MachineType { get => ReadHere<ushort>(nameof(MachineType)); set => WriteHere(nameof(MachineType), value); }

        [Offset(10UL)]
        public byte MaxPacketType { get => ReadHere<byte>(nameof(MaxPacketType)); set => WriteHere(nameof(MaxPacketType), value); }

        [Offset(11UL)]
        public byte MaxStateChange { get => ReadHere<byte>(nameof(MaxStateChange)); set => WriteHere(nameof(MaxStateChange), value); }

        [Offset(12UL)]
        public byte MaxManipulate { get => ReadHere<byte>(nameof(MaxManipulate)); set => WriteHere(nameof(MaxManipulate), value); }

        [Offset(13UL)]
        public byte Simulation { get => ReadHere<byte>(nameof(Simulation)); set => WriteHere(nameof(Simulation), value); }

        [Offset(14UL)]
        [Length(1)]
        public DynamicArray Unused { get => ReadStructure<DynamicArray>(nameof(Unused)); set => WriteStructure(nameof(Unused), value); }

        [Offset(16UL)]
        public ulong KernBase { get => ReadHere<ulong>(nameof(KernBase)); set => WriteHere(nameof(KernBase), value); }

        [Offset(24UL)]
        public ulong PsLoadedModuleList { get => ReadHere<ulong>(nameof(PsLoadedModuleList)); set => WriteHere(nameof(PsLoadedModuleList), value); }

        [Offset(32UL)]
        public ulong DebuggerDataList { get => ReadHere<ulong>(nameof(DebuggerDataList)); set => WriteHere(nameof(DebuggerDataList), value); }

        public DbgkdGetVERSION64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdGetVERSION64>();
        }
    }
}