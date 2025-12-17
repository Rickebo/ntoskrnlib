using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_REG_ENTRY")]
    public sealed class EtwRegEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry RegList { get => ReadStructure<ListEntry>(nameof(RegList)); set => WriteStructure(nameof(RegList), value); }

        [Offset(16UL)]
        public ListEntry GroupRegList { get => ReadStructure<ListEntry>(nameof(GroupRegList)); set => WriteStructure(nameof(GroupRegList), value); }

        [Offset(32UL)]
        public IntPtr GuidEntry { get => ReadHere<IntPtr>(nameof(GuidEntry)); set => WriteHere(nameof(GuidEntry), value); }

        [Offset(40UL)]
        public IntPtr GroupEntry { get => ReadHere<IntPtr>(nameof(GroupEntry)); set => WriteHere(nameof(GroupEntry), value); }

        [Offset(48UL)]
        public IntPtr ReplyQueue { get => ReadHere<IntPtr>(nameof(ReplyQueue)); set => WriteHere(nameof(ReplyQueue), value); }

        [Offset(48UL)]
        [Length(4)]
        public DynamicArray ReplySlot { get => ReadStructure<DynamicArray>(nameof(ReplySlot)); set => WriteStructure(nameof(ReplySlot), value); }

        [Offset(48UL)]
        public IntPtr Caller { get => ReadHere<IntPtr>(nameof(Caller)); set => WriteHere(nameof(Caller), value); }

        [Offset(56UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(80UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(80UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(88UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(96UL)]
        public ushort Index { get => ReadHere<ushort>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(98UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(98UL)]
        public ushort DbgKernelRegistration { get => ReadHere<ushort>(nameof(DbgKernelRegistration)); set => WriteHere(nameof(DbgKernelRegistration), value); }

        [Offset(98UL)]
        public ushort DbgUserRegistration { get => ReadHere<ushort>(nameof(DbgUserRegistration)); set => WriteHere(nameof(DbgUserRegistration), value); }

        [Offset(98UL)]
        public ushort DbgReplyRegistration { get => ReadHere<ushort>(nameof(DbgReplyRegistration)); set => WriteHere(nameof(DbgReplyRegistration), value); }

        [Offset(98UL)]
        public ushort DbgClassicRegistration { get => ReadHere<ushort>(nameof(DbgClassicRegistration)); set => WriteHere(nameof(DbgClassicRegistration), value); }

        [Offset(98UL)]
        public ushort DbgSessionSpaceRegistration { get => ReadHere<ushort>(nameof(DbgSessionSpaceRegistration)); set => WriteHere(nameof(DbgSessionSpaceRegistration), value); }

        [Offset(98UL)]
        public ushort DbgModernRegistration { get => ReadHere<ushort>(nameof(DbgModernRegistration)); set => WriteHere(nameof(DbgModernRegistration), value); }

        [Offset(98UL)]
        public ushort DbgClosed { get => ReadHere<ushort>(nameof(DbgClosed)); set => WriteHere(nameof(DbgClosed), value); }

        [Offset(98UL)]
        public ushort DbgInserted { get => ReadHere<ushort>(nameof(DbgInserted)); set => WriteHere(nameof(DbgInserted), value); }

        [Offset(98UL)]
        public ushort DbgWow64 { get => ReadHere<ushort>(nameof(DbgWow64)); set => WriteHere(nameof(DbgWow64), value); }

        [Offset(98UL)]
        public ushort DbgUseDescriptorType { get => ReadHere<ushort>(nameof(DbgUseDescriptorType)); set => WriteHere(nameof(DbgUseDescriptorType), value); }

        [Offset(98UL)]
        public ushort DbgDropProviderTraits { get => ReadHere<ushort>(nameof(DbgDropProviderTraits)); set => WriteHere(nameof(DbgDropProviderTraits), value); }

        [Offset(100UL)]
        public byte EnableMask { get => ReadHere<byte>(nameof(EnableMask)); set => WriteHere(nameof(EnableMask), value); }

        [Offset(101UL)]
        public byte GroupEnableMask { get => ReadHere<byte>(nameof(GroupEnableMask)); set => WriteHere(nameof(GroupEnableMask), value); }

        [Offset(102UL)]
        public byte HostEnableMask { get => ReadHere<byte>(nameof(HostEnableMask)); set => WriteHere(nameof(HostEnableMask), value); }

        [Offset(103UL)]
        public byte HostGroupEnableMask { get => ReadHere<byte>(nameof(HostGroupEnableMask)); set => WriteHere(nameof(HostGroupEnableMask), value); }

        [Offset(104UL)]
        public IntPtr Traits { get => ReadHere<IntPtr>(nameof(Traits)); set => WriteHere(nameof(Traits), value); }

        public EtwRegEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwRegEntry>();
        }
    }
}