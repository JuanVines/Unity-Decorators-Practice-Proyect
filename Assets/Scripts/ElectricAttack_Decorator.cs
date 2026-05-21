/// <summary>
/// Concrete Decorator that adds electric attack enhancement to the weapon.
/// Increases damage and attack speed of the weapon data.
/// Also modifies the attack behavior to include an electric shock effect.
/// </summary>
public class ElectricAttack_Decorator : Base_WeaponDecorator
{
    /// <summary>
    /// Modifications to the Original weapon data shouldn't be done directly by Decorators. 
    /// This is only for ilustration purposes, but in a real implementation, you would want to avoid modifying the original weapon data directly, as it could affect other decorators or the base weapon.
    /// </summary>
    /// <param name="wrappedWeapon"></param>
    public ElectricAttack_Decorator(IWeapon wrappedWeapon) : base(wrappedWeapon) 
    { 
        weaponData.damage += 5; // Increase damage by 5 for electric attack
        weaponData.attackSpeed += 0.5f; // Increase attack speed by 0.5 for electric attack
    }

    /// <summary>
    /// Chains the behaviour of the previous method and adds the electric shock effect to the attack description.
    /// </summary>
    /// <returns></returns>
    public override string Attack()
    {
        string baseAttack = base.Attack();
        return $"{baseAttack} & with an electric shock!";
    }
}
