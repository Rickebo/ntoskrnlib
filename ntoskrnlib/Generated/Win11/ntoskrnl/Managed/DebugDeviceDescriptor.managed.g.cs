using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEBUG_DEVICE_DESCRIPTOR")]
    public sealed class DebugDeviceDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint Bus { get => ReadHere<uint>(nameof(Bus)); set => WriteHere(nameof(Bus), value); }

        [Offset(4UL)]
        public uint Slot { get => ReadHere<uint>(nameof(Slot)); set => WriteHere(nameof(Slot), value); }

        [Offset(8UL)]
        public ushort Segment { get => ReadHere<ushort>(nameof(Segment)); set => WriteHere(nameof(Segment), value); }

        [Offset(10UL)]
        public ushort VendorID { get => ReadHere<ushort>(nameof(VendorID)); set => WriteHere(nameof(VendorID), value); }

        [Offset(12UL)]
        public ushort DeviceID { get => ReadHere<ushort>(nameof(DeviceID)); set => WriteHere(nameof(DeviceID), value); }

        [Offset(14UL)]
        public byte BaseClass { get => ReadHere<byte>(nameof(BaseClass)); set => WriteHere(nameof(BaseClass), value); }

        [Offset(15UL)]
        public byte SubClass { get => ReadHere<byte>(nameof(SubClass)); set => WriteHere(nameof(SubClass), value); }

        [Offset(16UL)]
        public byte ProgIf { get => ReadHere<byte>(nameof(ProgIf)); set => WriteHere(nameof(ProgIf), value); }

        [Offset(17UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(17UL)]
        public byte DbgHalScratchAllocated { get => ReadHere<byte>(nameof(DbgHalScratchAllocated)); set => WriteHere(nameof(DbgHalScratchAllocated), value); }

        [Offset(17UL)]
        public byte DbgBarsMapped { get => ReadHere<byte>(nameof(DbgBarsMapped)); set => WriteHere(nameof(DbgBarsMapped), value); }

        [Offset(17UL)]
        public byte DbgScratchAllocated { get => ReadHere<byte>(nameof(DbgScratchAllocated)); set => WriteHere(nameof(DbgScratchAllocated), value); }

        [Offset(17UL)]
        public byte DbgUncachedMemory { get => ReadHere<byte>(nameof(DbgUncachedMemory)); set => WriteHere(nameof(DbgUncachedMemory), value); }

        [Offset(17UL)]
        public byte DbgSynthetic { get => ReadHere<byte>(nameof(DbgSynthetic)); set => WriteHere(nameof(DbgSynthetic), value); }

        [Offset(18UL)]
        public byte Initialized { get => ReadHere<byte>(nameof(Initialized)); set => WriteHere(nameof(Initialized), value); }

        [Offset(19UL)]
        public byte Configured { get => ReadHere<byte>(nameof(Configured)); set => WriteHere(nameof(Configured), value); }

        [Offset(24UL)]
        [Length(6)]
        public DynamicArray BaseAddress { get => ReadStructure<DynamicArray>(nameof(BaseAddress)); set => WriteStructure(nameof(BaseAddress), value); }

        [Offset(168UL)]
        public DebugMemoryRequirements Memory { get => ReadStructure<DebugMemoryRequirements>(nameof(Memory)); set => WriteStructure(nameof(Memory), value); }

        [Offset(200UL)]
        public uint Dbg2TableIndex { get => ReadHere<uint>(nameof(Dbg2TableIndex)); set => WriteHere(nameof(Dbg2TableIndex), value); }

        [Offset(204UL)]
        public ushort PortType { get => ReadHere<ushort>(nameof(PortType)); set => WriteHere(nameof(PortType), value); }

        [Offset(206UL)]
        public ushort PortSubtype { get => ReadHere<ushort>(nameof(PortSubtype)); set => WriteHere(nameof(PortSubtype), value); }

        [Offset(208UL)]
        public IntPtr OemData { get => ReadHere<IntPtr>(nameof(OemData)); set => WriteHere(nameof(OemData), value); }

        [Offset(216UL)]
        public uint OemDataLength { get => ReadHere<uint>(nameof(OemDataLength)); set => WriteHere(nameof(OemDataLength), value); }

        [Offset(220UL)]
        public uint NameSpace { get => ReadHere<uint>(nameof(NameSpace)); set => WriteHere(nameof(NameSpace), value); }

        [Offset(224UL)]
        public IntPtr NameSpacePath { get => ReadHere<IntPtr>(nameof(NameSpacePath)); set => WriteHere(nameof(NameSpacePath), value); }

        [Offset(232UL)]
        public uint NameSpacePathLength { get => ReadHere<uint>(nameof(NameSpacePathLength)); set => WriteHere(nameof(NameSpacePathLength), value); }

        [Offset(236UL)]
        public uint TransportType { get => ReadHere<uint>(nameof(TransportType)); set => WriteHere(nameof(TransportType), value); }

        [Offset(240UL)]
        public DebugTransportData TransportData { get => ReadStructure<DebugTransportData>(nameof(TransportData)); set => WriteStructure(nameof(TransportData), value); }

        [Offset(256UL)]
        public DebugIommuEfiData EfiIoMmuData { get => ReadStructure<DebugIommuEfiData>(nameof(EfiIoMmuData)); set => WriteStructure(nameof(EfiIoMmuData), value); }

        public DebugDeviceDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DebugDeviceDescriptor>();
        }
    }
}