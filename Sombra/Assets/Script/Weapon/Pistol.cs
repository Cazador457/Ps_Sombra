using UnityEngine;

public class Pistol : RangeWeapon
{
    public override void Attack()
    {
        Ligthshoot.instance.ActiveLight();
        Ray ray = new Ray(pointToShoot.position, pointToShoot.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Disparando" + hit.collider);
            //Debug.DrawLine(pointToShoot.position, hit.collider);
        }
    }
}
