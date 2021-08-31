using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// attached to response choices that will have negative impact on th relationship with the other characters
public class Response1 : MonoBehaviour
{
    public Slider slider;
    public float trust = 50;
    public Button mybutton;
    // Start is called before the first frame update
    void Start()
    {
        Button response = mybutton.GetComponent<Button>();
        response.onClick.AddListener(TaskButtonClick);

    }

    void TaskButtonClick()
    {
        trust -= 50f;
        slider.value = trust;

    }
}
