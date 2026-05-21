/// <summary>
/// Concrete Decorator.
/// Increases the damage of the weapon by adding a diamond tip to it.
/// Also adds a description of the diamond tip effect to the attack behavior.
/// </summary>
public class DiamondTip_Decorator : Base_WeaponDecorator
{
    /// <summary>
    /// Modifications to the Original weapon data shouldn't be done directly by Decorators. 
    /// This is only for ilustration purposes, but in a real implementation, you would want to avoid modifying the original weapon data directly, as it could affect other decorators or the base weapon.
    /// </summary>
    /// <param name="wrappedWeapon"></param>
    public DiamondTip_Decorator(IWeapon _wrappedWeapon) : base(_wrappedWeapon) 
    { 
        weaponData.damage += 20; // Increase damage by 20 for diamond tip
    }

    /// <summary>
    /// Chains the behaviour of the previous method and adds the diamond tip effect to the attack description.
    /// </summary>
    /// <returns></returns>
    public override string Attack()
    {
        string baseAttack = base.Attack();
        return $"{baseAttack} & with a diamond tip!";
    }
}
