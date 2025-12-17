using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SILO_USER_SHARED_DATA")]
    public sealed class SiloUserSharedData : DynamicStructure
    {
        [Offset(0UL)]
        public uint ServiceSessionId { get => ReadHere<uint>(nameof(ServiceSessionId)); set => WriteHere(nameof(ServiceSessionId), value); }

        [Offset(4UL)]
        public uint ActiveConsoleId { get => ReadHere<uint>(nameof(ActiveConsoleId)); set => WriteHere(nameof(ActiveConsoleId), value); }

        [Offset(8UL)]
        public long ConsoleSessionForegroundProcessId { get => ReadHere<long>(nameof(ConsoleSessionForegroundProcessId)); set => WriteHere(nameof(ConsoleSessionForegroundProcessId), value); }

        [Offset(16UL)]
        public uint NtProductType { get => ReadHere<uint>(nameof(NtProductType)); set => WriteHere(nameof(NtProductType), value); }

        [Offset(20UL)]
        public uint SuiteMask { get => ReadHere<uint>(nameof(SuiteMask)); set => WriteHere(nameof(SuiteMask), value); }

        [Offset(24UL)]
        public uint SharedUserSessionId { get => ReadHere<uint>(nameof(SharedUserSessionId)); set => WriteHere(nameof(SharedUserSessionId), value); }

        [Offset(28UL)]
        public byte IsMultiSessionSku { get => ReadHere<byte>(nameof(IsMultiSessionSku)); set => WriteHere(nameof(IsMultiSessionSku), value); }

        [Offset(29UL)]
        public byte IsStateSeparationEnabled { get => ReadHere<byte>(nameof(IsStateSeparationEnabled)); set => WriteHere(nameof(IsStateSeparationEnabled), value); }

        [Offset(30UL)]
        [Length(260)]
        public DynamicArray NtSystemRoot { get => ReadStructure<DynamicArray>(nameof(NtSystemRoot)); set => WriteStructure(nameof(NtSystemRoot), value); }

        [Offset(550UL)]
        [Length(16)]
        public DynamicArray UserModeGlobalLogger { get => ReadStructure<DynamicArray>(nameof(UserModeGlobalLogger)); set => WriteStructure(nameof(UserModeGlobalLogger), value); }

        [Offset(584UL)]
        public uint TimeZoneId { get => ReadHere<uint>(nameof(TimeZoneId)); set => WriteHere(nameof(TimeZoneId), value); }

        [Offset(588UL)]
        public int TimeZoneBiasStamp { get => ReadHere<int>(nameof(TimeZoneBiasStamp)); set => WriteHere(nameof(TimeZoneBiasStamp), value); }

        [Offset(592UL)]
        public KsystemTime TimeZoneBias { get => ReadStructure<KsystemTime>(nameof(TimeZoneBias)); set => WriteStructure(nameof(TimeZoneBias), value); }

        [Offset(608UL)]
        public LargeInteger TimeZoneBiasEffectiveStart { get => ReadStructure<LargeInteger>(nameof(TimeZoneBiasEffectiveStart)); set => WriteStructure(nameof(TimeZoneBiasEffectiveStart), value); }

        [Offset(616UL)]
        public LargeInteger TimeZoneBiasEffectiveEnd { get => ReadStructure<LargeInteger>(nameof(TimeZoneBiasEffectiveEnd)); set => WriteStructure(nameof(TimeZoneBiasEffectiveEnd), value); }

        public SiloUserSharedData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SiloUserSharedData>();
        }
    }
}