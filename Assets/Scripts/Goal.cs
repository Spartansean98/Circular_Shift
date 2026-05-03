using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int levelID;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(levelID);
    }
}
