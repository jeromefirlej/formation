namespace ProfileCards.ProfilesManagement.Translators
{
    internal interface ITranslator<in TIn, out TOut>
    {
        TOut From(TIn input);
    }
}