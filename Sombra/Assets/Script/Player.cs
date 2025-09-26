using UnityEngine;

public class Player : MonoBehaviour
{
    public Weapon weapon;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon?.Attack();
        }
    }
    
}
