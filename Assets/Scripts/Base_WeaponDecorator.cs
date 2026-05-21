/// <summary>
/// Abstract Base Decorator class.
/// Implements IWeapon interface and has a reference to an IWeapon object (the component it decorates).
/// Referenced IWeapon could be either the concrete component (Lance) or another decorator, allowing for multiple layers of decoration.
/// </summary>
public abstract class Base_WeaponDecorator : IWeapon
{
    public WeaponData weaponData { get; set; }

    /// <summary>
    /// Reference to the wrapped IWeapon object. 
    /// This is the component that this decorator will enhance or modify.
    /// Could be either be the concrete component (Lance) or another decorator, allowing for multiple layers of decoration.
    /// </summary>
    protected IWeapon wrappedWeapon;

    /// <summary>
    /// Receives an IWeapon object to wrap (decorate).
    /// </summary>
    /// <param name="_wrappedWeapon"></param>
    public Base_WeaponDecorator(IWeapon _wrappedWeapon)
    {
        wrappedWeapon = _wrappedWeapon;
        weaponData = wrappedWeapon.weaponData;
    }

    /// <summary>
    /// Delegates the Attack method to the wrapped weapon. 
    /// Call upon the base weapon's method, and then each decorator can add its own behavior before or after calling the base method.
    /// </summary>
    /// <returns></returns>
    public virtual string Attack()
    {
        return wrappedWeapon.Attack();
    }
}
