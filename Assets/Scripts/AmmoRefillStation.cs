using UnityEngine;

public class AmmoRefillStation : MonoBehaviour
{
    // this is giving me brain damage
    // unity please just add OnControllerColliderExit
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<FPSController>())
        {
            Debug.Log("Refill Enabled");
            col.gameObject.GetComponent<FPSController>().canRefillAmmo = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.GetComponent<FPSController>())
        {
            Debug.Log("Refill Disabled");
            col.gameObject.GetComponent<FPSController>().canRefillAmmo = false;
        }
    }
}
