using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    public AudioSource sound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            KillPlayer(collision.gameObject);
        }
    }

    public void KillPlayer(GameObject player)
    {
        player.SetActive(false);
        sound.Play();
        StartCoroutine(NewScene());
        
    }

    public IEnumerator NewScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
