namespace GFramework.core.domainEntities
{
    /// <summary>
    /// This Interface should be use if the Entity being Inserted needs to be validated at the moment of persistence (for both Update and Insert)
    /// </summary>
    public interface IValidateableEntity
    {

        bool IsValid { get; }


        void Validate();
        
    }
}
