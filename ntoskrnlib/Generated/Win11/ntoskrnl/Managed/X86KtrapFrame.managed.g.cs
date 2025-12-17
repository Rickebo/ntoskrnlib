using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_X86_KTRAP_FRAME")]
    public sealed class X86KtrapFrame : DynamicStructure
    {
        [Offset(0UL)]
        public uint DbgEbp { get => ReadHere<uint>(nameof(DbgEbp)); set => WriteHere(nameof(DbgEbp), value); }

        [Offset(4UL)]
        public uint DbgEip { get => ReadHere<uint>(nameof(DbgEip)); set => WriteHere(nameof(DbgEip), value); }

        [Offset(8UL)]
        public uint DbgArgMark { get => ReadHere<uint>(nameof(DbgArgMark)); set => WriteHere(nameof(DbgArgMark), value); }

        [Offset(12UL)]
        public uint DbgArgPointer { get => ReadHere<uint>(nameof(DbgArgPointer)); set => WriteHere(nameof(DbgArgPointer), value); }

        [Offset(16UL)]
        public uint TempSegCs { get => ReadHere<uint>(nameof(TempSegCs)); set => WriteHere(nameof(TempSegCs), value); }

        [Offset(20UL)]
        public uint TempEsp { get => ReadHere<uint>(nameof(TempEsp)); set => WriteHere(nameof(TempEsp), value); }

        [Offset(24UL)]
        public uint Dr0 { get => ReadHere<uint>(nameof(Dr0)); set => WriteHere(nameof(Dr0), value); }

        [Offset(28UL)]
        public uint Dr1 { get => ReadHere<uint>(nameof(Dr1)); set => WriteHere(nameof(Dr1), value); }

        [Offset(32UL)]
        public uint Dr2 { get => ReadHere<uint>(nameof(Dr2)); set => WriteHere(nameof(Dr2), value); }

        [Offset(36UL)]
        public uint Dr3 { get => ReadHere<uint>(nameof(Dr3)); set => WriteHere(nameof(Dr3), value); }

        [Offset(40UL)]
        public uint Dr6 { get => ReadHere<uint>(nameof(Dr6)); set => WriteHere(nameof(Dr6), value); }

        [Offset(44UL)]
        public uint Dr7 { get => ReadHere<uint>(nameof(Dr7)); set => WriteHere(nameof(Dr7), value); }

        [Offset(48UL)]
        public uint SegGs { get => ReadHere<uint>(nameof(SegGs)); set => WriteHere(nameof(SegGs), value); }

        [Offset(52UL)]
        public uint SegEs { get => ReadHere<uint>(nameof(SegEs)); set => WriteHere(nameof(SegEs), value); }

        [Offset(56UL)]
        public uint SegDs { get => ReadHere<uint>(nameof(SegDs)); set => WriteHere(nameof(SegDs), value); }

        [Offset(60UL)]
        public uint Edx { get => ReadHere<uint>(nameof(Edx)); set => WriteHere(nameof(Edx), value); }

        [Offset(64UL)]
        public uint Ecx { get => ReadHere<uint>(nameof(Ecx)); set => WriteHere(nameof(Ecx), value); }

        [Offset(68UL)]
        public uint Eax { get => ReadHere<uint>(nameof(Eax)); set => WriteHere(nameof(Eax), value); }

        [Offset(72UL)]
        public byte PreviousPreviousMode { get => ReadHere<byte>(nameof(PreviousPreviousMode)); set => WriteHere(nameof(PreviousPreviousMode), value); }

        [Offset(73UL)]
        public byte EntropyQueueDpc { get => ReadHere<byte>(nameof(EntropyQueueDpc)); set => WriteHere(nameof(EntropyQueueDpc), value); }

        [Offset(74UL)]
        [Length(2)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(76UL)]
        public uint ExceptionList { get => ReadHere<uint>(nameof(ExceptionList)); set => WriteHere(nameof(ExceptionList), value); }

        [Offset(80UL)]
        public uint SegFs { get => ReadHere<uint>(nameof(SegFs)); set => WriteHere(nameof(SegFs), value); }

        [Offset(84UL)]
        public uint Edi { get => ReadHere<uint>(nameof(Edi)); set => WriteHere(nameof(Edi), value); }

        [Offset(88UL)]
        public uint Esi { get => ReadHere<uint>(nameof(Esi)); set => WriteHere(nameof(Esi), value); }

        [Offset(92UL)]
        public uint Ebx { get => ReadHere<uint>(nameof(Ebx)); set => WriteHere(nameof(Ebx), value); }

        [Offset(96UL)]
        public uint Ebp { get => ReadHere<uint>(nameof(Ebp)); set => WriteHere(nameof(Ebp), value); }

        [Offset(100UL)]
        public uint ErrCode { get => ReadHere<uint>(nameof(ErrCode)); set => WriteHere(nameof(ErrCode), value); }

        [Offset(104UL)]
        public uint Eip { get => ReadHere<uint>(nameof(Eip)); set => WriteHere(nameof(Eip), value); }

        [Offset(108UL)]
        public uint SegCs { get => ReadHere<uint>(nameof(SegCs)); set => WriteHere(nameof(SegCs), value); }

        [Offset(112UL)]
        public uint EFlags { get => ReadHere<uint>(nameof(EFlags)); set => WriteHere(nameof(EFlags), value); }

        [Offset(116UL)]
        public uint HardwareEsp { get => ReadHere<uint>(nameof(HardwareEsp)); set => WriteHere(nameof(HardwareEsp), value); }

        [Offset(120UL)]
        public uint HardwareSegSs { get => ReadHere<uint>(nameof(HardwareSegSs)); set => WriteHere(nameof(HardwareSegSs), value); }

        [Offset(124UL)]
        public uint V86Es { get => ReadHere<uint>(nameof(V86Es)); set => WriteHere(nameof(V86Es), value); }

        [Offset(128UL)]
        public uint V86Ds { get => ReadHere<uint>(nameof(V86Ds)); set => WriteHere(nameof(V86Ds), value); }

        [Offset(132UL)]
        public uint V86Fs { get => ReadHere<uint>(nameof(V86Fs)); set => WriteHere(nameof(V86Fs), value); }

        [Offset(136UL)]
        public uint V86Gs { get => ReadHere<uint>(nameof(V86Gs)); set => WriteHere(nameof(V86Gs), value); }

        public X86KtrapFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<X86KtrapFrame>();
        }
    }
}