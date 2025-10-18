using ntoskrnlib.Symbols;

namespace ntoskrnlib.Abstractions;

internal interface ISymbolSessionFactory
{
    SymbolSession Create(string modulePath, string? symbolPath = null);
}

