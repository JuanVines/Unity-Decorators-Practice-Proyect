using UnityEngine;

/// <summary>
/// Concrete component in the Decorator pattern. This is the base weapon that can be decorated with different enhancements.
/// Defines the basic properties and behavior of a lance weapon, such as damage, durability, attack speed, and range.
/// Core of Decorator chain, it will be wrapped by decorators to add new functionalities or modify existing ones without changing the original class.
/// All Decorators are piled on top of this base weapon.
/// </summary>
public class Lance : IWeapon
{
    public WeaponData weaponData { get; set; }

    /// <summary>
    /// Initializes the lance weapon with default stats. 
    /// </summary>
    /// <param name="lanceTransform"></param>
    public Lance(Transform lanceTransform)
    {
        weaponData = new WeaponData(lanceTransform);
        weaponData.damage = 10;
        weaponData.durability = 100;
        weaponData.attackSpeed = 1.5f;
        weaponData.range = 2.0f;
    }

    /// <summary>
    /// Base method of the lance weapon. 
    /// First step in the Decorator chain, it will be called by the first decorator, and then each decorator will add its own behavior before or after calling the base method.
    /// Every Decorator will call this method at some point.
    /// </summary>
    /// <returns></returns>
    public string Attack()
    {
        return $"Lance attack! Damage: {weaponData.damage}, Durability: {weaponData.durability}, AtackSpeed: {weaponData.attackSpeed}, Range: {weaponData.range}";
    }
}
