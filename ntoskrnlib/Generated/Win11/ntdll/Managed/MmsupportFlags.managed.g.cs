using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MMSUPPORT_FLAGS")]
    public sealed class MmsupportFlags : DynamicStructure
    {
        [Offset(0UL)]
        public byte WorkingSetType { get => ReadHere<byte>(nameof(WorkingSetType)); set => WriteHere(nameof(WorkingSetType), value); }

        [Offset(0UL)]
        public byte Reserved0 { get => ReadHere<byte>(nameof(Reserved0)); set => WriteHere(nameof(Reserved0), value); }

        [Offset(0UL)]
        public byte MaximumWorkingSetHard { get => ReadHere<byte>(nameof(MaximumWorkingSetHard)); set => WriteHere(nameof(MaximumWorkingSetHard), value); }

        [Offset(0UL)]
        public byte MinimumWorkingSetHard { get => ReadHere<byte>(nameof(MinimumWorkingSetHard)); set => WriteHere(nameof(MinimumWorkingSetHard), value); }

        [Offset(1UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(1UL)]
        public byte TrimmerState { get => ReadHere<byte>(nameof(TrimmerState)); set => WriteHere(nameof(TrimmerState), value); }

        [Offset(1UL)]
        public byte LinearAddressProtected { get => ReadHere<byte>(nameof(LinearAddressProtected)); set => WriteHere(nameof(LinearAddressProtected), value); }

        [Offset(1UL)]
        public byte PageStealers { get => ReadHere<byte>(nameof(PageStealers)); set => WriteHere(nameof(PageStealers), value); }

        [Offset(0UL)]
        public ushort u1 { get => ReadHere<ushort>(nameof(u1)); set => WriteHere(nameof(u1), value); }

        [Offset(2UL)]
        public byte MemoryPriority { get => ReadHere<byte>(nameof(MemoryPriority)); set => WriteHere(nameof(MemoryPriority), value); }

        [Offset(3UL)]
        public byte WsleDeleted { get => ReadHere<byte>(nameof(WsleDeleted)); set => WriteHere(nameof(WsleDeleted), value); }

        [Offset(3UL)]
        public byte SvmEnabled { get => ReadHere<byte>(nameof(SvmEnabled)); set => WriteHere(nameof(SvmEnabled), value); }

        [Offset(3UL)]
        public byte ForceAge { get => ReadHere<byte>(nameof(ForceAge)); set => WriteHere(nameof(ForceAge), value); }

        [Offset(3UL)]
        public byte ForceTrim { get => ReadHere<byte>(nameof(ForceTrim)); set => WriteHere(nameof(ForceTrim), value); }

        [Offset(3UL)]
        public byte CommitReleaseState { get => ReadHere<byte>(nameof(CommitReleaseState)); set => WriteHere(nameof(CommitReleaseState), value); }

        [Offset(3UL)]
        public byte Reserved2 { get => ReadHere<byte>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(3UL)]
        public byte u2 { get => ReadHere<byte>(nameof(u2)); set => WriteHere(nameof(u2), value); }

        [Offset(0UL)]
        public uint EntireFlags { get => ReadHere<uint>(nameof(EntireFlags)); set => WriteHere(nameof(EntireFlags), value); }

        public MmsupportFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsupportFlags>();
        }
    }
}