using UnityEngine;
using System.Collections;
public class Ligthshoot : MonoBehaviour
{
    public static Ligthshoot instance;
    public Light pointLight;
    [ContextMenu("Simulate Light")]
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        pointLight.enabled = false;
    }
    public void ActiveLight()
    {
        StartCoroutine(RoutineEnableLight());
    }
    IEnumerator RoutineEnableLight()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Finish");
    }
}
