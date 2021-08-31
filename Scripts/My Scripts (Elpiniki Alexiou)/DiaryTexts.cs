using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryTexts : MonoBehaviour
{
    public List<TypeWriting> DiaryLines;

    void Start()
    {
        for (int i = 0; i <= DiaryLines.Count; i++)
        {
            DiaryLines[i].gameObject.SetActive(false);
            StartCoroutine(waitForZoom());
        }
    }
    IEnumerator waitForZoom()
    {

        for (int i = 0; i <= DiaryLines.Count; i++)
    {
        yield return new WaitForSeconds(4f);
        DiaryLines[0].gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        DiaryLines[1].gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        DiaryLines[2].gameObject.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        DiaryLines[3].gameObject.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        DiaryLines[4].gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        DiaryLines[5].gameObject.SetActive(true);
        }
     }
}
