using UnityEngine;

/// <summary>
/// Contains the data for a weapon
/// Has a constructor that takes a Transform and initializes the weapon data with it
/// </summary>
public class WeaponData
{
    readonly public Transform _weaponTransform;
    public int damage;
    public int durability;
    public float attackSpeed;
    public float range;

    public WeaponData(Transform weaponTransform)
    {
        _weaponTransform = weaponTransform;
    }
}
