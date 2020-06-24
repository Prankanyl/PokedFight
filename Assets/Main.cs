using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public float timeStart = 7f;
    public Text Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            Timer.text = Mathf.Round(timeStart).ToString();
        }
        if (timeStart <= 0)
        {
            timeStart = 7f;
            timeStart -= Time.deltaTime;
            Timer.text = Mathf.Round(timeStart).ToString();
        }

    }
}
