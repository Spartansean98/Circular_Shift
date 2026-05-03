using UnityEngine;

public class CloudPlatformTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            transform.parent.GetComponent<CloudPlatform>().HidePlatform();
        }
    }
}
