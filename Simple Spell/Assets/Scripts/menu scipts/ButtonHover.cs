using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject buttonImage;
    public float timeTowait = 0.5f;

    void Start()
    {
        buttonImage.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(EnterTimer());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ExitTimer());
    }


    private IEnumerator EnterTimer()
    {
        yield return new WaitForSeconds(timeTowait);

        buttonImage.SetActive(true);
    }

    private IEnumerator ExitTimer()
    {
        yield return new WaitForSeconds(timeTowait);

        buttonImage.SetActive(false);
    }

}
