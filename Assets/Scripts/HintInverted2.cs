using TMPro;
using UnityEngine;

public class HintInverted2 : MonoBehaviour
{
    public float timer;
    public float hintSpawnTime = 5;
    public float easyHintSpawnTime = 20;
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;

        if(timer>hintSpawnTime)
        {
            if(timer>easyHintSpawnTime)
            {
                text.text = "I can hang on to the roof";
                this.enabled = false;
            }
            else
            {
             text.text = "but what about the roof?";
            }

        }
    }
}
