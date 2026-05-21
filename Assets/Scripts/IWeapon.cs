/// <summary>
/// Base interface for Decorator pattern.
/// Both concrete component and all decorators will implement this interface.
/// That way we can use them interchangeably.
/// </summary>
public interface IWeapon
{
    WeaponData weaponData { get; set; }

    /// <summary>
    /// Shared method that will be implemented by both concrete component and decorators.
    /// Each Decorator can add its own behavior before or after calling the base method.
    /// </summary>
    /// <returns></returns>
    string Attack();
}
