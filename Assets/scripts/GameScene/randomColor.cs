using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    public float minHeu, maxHeu, minSaturation, maxSaturation, valueMin, valueMax;
    
    void Start()
    {
        changeColor();
    }


    void changeColor() 
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(minHeu, maxHeu, minSaturation, maxSaturation, valueMin, valueMax);
    }
}
