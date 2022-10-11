namespace CodeDesignPlus.Core.Abstractions;

public interface IDtoBase : IBase { }

public interface IDtoBase<TKey, TUserKey> : IBase<TKey, TUserKey>, IDtoBase
{
}