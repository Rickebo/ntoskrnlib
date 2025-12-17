using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_DSM_DEFINITION")]
    public sealed class DeviceDsmDefinition : DynamicStructure
    {
        [Offset(0UL)]
        public uint Action { get => ReadHere<uint>(nameof(Action)); set => WriteHere(nameof(Action), value); }

        [Offset(4UL)]
        public byte SingleRange { get => ReadHere<byte>(nameof(SingleRange)); set => WriteHere(nameof(SingleRange), value); }

        [Offset(8UL)]
        public uint ParameterBlockAlignment { get => ReadHere<uint>(nameof(ParameterBlockAlignment)); set => WriteHere(nameof(ParameterBlockAlignment), value); }

        [Offset(12UL)]
        public uint ParameterBlockLength { get => ReadHere<uint>(nameof(ParameterBlockLength)); set => WriteHere(nameof(ParameterBlockLength), value); }

        [Offset(16UL)]
        public byte HasOutput { get => ReadHere<byte>(nameof(HasOutput)); set => WriteHere(nameof(HasOutput), value); }

        [Offset(20UL)]
        public uint OutputBlockAlignment { get => ReadHere<uint>(nameof(OutputBlockAlignment)); set => WriteHere(nameof(OutputBlockAlignment), value); }

        [Offset(24UL)]
        public uint OutputBlockLength { get => ReadHere<uint>(nameof(OutputBlockLength)); set => WriteHere(nameof(OutputBlockLength), value); }

        public DeviceDsmDefinition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceDsmDefinition>();
        }
    }
}