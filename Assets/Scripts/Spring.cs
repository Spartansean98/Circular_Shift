using UnityEngine;

public class Spring : MonoBehaviour
{
    public int boost = 5;
    public AudioSource sound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            sound.Play();
            collision.GetComponent<PlayerController>().SpringJump(boost);
        }
    }
}
