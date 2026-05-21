using UnityEngine;

/// <summary>
/// Client code that uses the IWeapon interface and the Decorator pattern to create a lance weapon and add enhancements to it.
/// Works around the IWeapon interface, creating a Lance object and then wrapping it with different decorators to add new functionalities or modify existing ones without changing the original class.
/// </summary>
public class LanceController : MonoBehaviour
{
    /// <summary>
    /// Reference to the IWeapon object.
    /// Could be either be the concrete component (Lance) or a decorated version of it, allowing for dynamic addition of enhancements at runtime.
    /// The controller doesn't need to know the specific type of weapon it is using, it just interacts with the IWeapon interface, allowing for flexibility and extensibility in the weapon system.
    /// </summary>
    IWeapon _weapon;
    MeshRenderer _renderer;
    [SerializeField] Renderer _tip;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();

        // Initializes the base weapon without any enhancements.
        _weapon = new Lance(this.transform);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(_weapon.Attack());
        }   

        // Applies Decorator enhancement to the weapon.
        if(Input.GetKeyDown(KeyCode.E))
        {
            AddElectricity();
        }

        // Applies Decorator enhancement to the weapon.
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddDiamondTip();
        }
    }

    /// <summary>
    /// Decorates current weapon with the electricity Decorator, changing its behavior and appearance to reflect the new functionality.
    /// Now _weapon points towards the new decorator, which internally holds a reference to the previous IWeapon.
    /// </summary>
    void AddElectricity()
    {
        Debug.Log("Electricity added to weapon!");
        _weapon = new ElectricAttack_Decorator(_weapon);
        _renderer.material.color = Color.blue;
    }

    /// <summary>
    /// Decorates current weapon with the DiamondTip Decorator, changing its behavior and appearance to reflect the new functionality.
    /// Now _weapon points towards the new decorator, which internally holds a reference to the previous IWeapon.
    /// </summary>
    void AddDiamondTip()
    {
        Debug.Log("Diamond tip added to weapon!");
        _weapon = new DiamondTip_Decorator(_weapon);
        _tip.material.color = Color.cyan;
    }
}
