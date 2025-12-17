using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_TIMER_SUBQUEUE")]
    public sealed class TppTimerSubqueue : DynamicStructure
    {
        [Offset(0UL)]
        public long Expiration { get => ReadHere<long>(nameof(Expiration)); set => WriteHere(nameof(Expiration), value); }

        [Offset(8UL)]
        public TppPh WindowStart { get => ReadStructure<TppPh>(nameof(WindowStart)); set => WriteStructure(nameof(WindowStart), value); }

        [Offset(16UL)]
        public TppPh WindowEnd { get => ReadStructure<TppPh>(nameof(WindowEnd)); set => WriteStructure(nameof(WindowEnd), value); }

        [Offset(24UL)]
        public IntPtr Timer { get => ReadHere<IntPtr>(nameof(Timer)); set => WriteHere(nameof(Timer), value); }

        [Offset(32UL)]
        public IntPtr TimerPkt { get => ReadHere<IntPtr>(nameof(TimerPkt)); set => WriteHere(nameof(TimerPkt), value); }

        [Offset(40UL)]
        public TpDirect Direct { get => ReadStructure<TpDirect>(nameof(Direct)); set => WriteStructure(nameof(Direct), value); }

        [Offset(112UL)]
        public uint ExpirationWindow { get => ReadHere<uint>(nameof(ExpirationWindow)); set => WriteHere(nameof(ExpirationWindow), value); }

        public TppTimerSubqueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppTimerSubqueue>();
        }
    }
}