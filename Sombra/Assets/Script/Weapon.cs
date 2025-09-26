using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("weapon Propwerties")]
    public int damage;

    public virtual void Attack()
    {
        Debug.Log("Hounting");
    }
}
