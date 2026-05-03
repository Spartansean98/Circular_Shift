using System.Collections;
using UnityEngine;

public class CloudPlatform : MonoBehaviour
{
public GameObject platform;
    public void HidePlatform()
    {
        StartCoroutine(Hide());
        StartCoroutine(Unhide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(0.5f);
        platform.SetActive(false);
    }
    IEnumerator Unhide()
    {
        yield return new WaitForSeconds(4);
        platform.SetActive(true);
    }
    }
