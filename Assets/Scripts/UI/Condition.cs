using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float maxValue;
    public float curValue;
    public float startValue;
    public float passiveValue;
    public Image bar;

    // Start is called before the first frame update
    void Start()
    {
        curValue = startValue;
    }

    void Update()
    {
        bar.fillAmount = curValue/maxValue;
    }

    public void Add(float value)
    {
        curValue = Mathf.Min(curValue+value, maxValue); 
        curValue = Mathf.Max(curValue, 0); 
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);
    }
}
