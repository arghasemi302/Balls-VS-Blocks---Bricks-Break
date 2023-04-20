using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public TextMesh[] Numtext;

    public int Damage = 0;

    private blockSetNum blockSet;

    void Start()
    {
        blockSet = transform.parent.GetComponent<blockSetNum>();
        randomColor();
        updateText();
    }

    void randomColor()
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 0.5f, 1f, 0.5f, 1.5f);
    }

    void updateText()
    {
        for (int i = 0; i < Numtext.Length; i++)
        {
            Numtext[i].text = "" + Damage;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            TakeDamage();
        }
    }

    void TakeDamage() 
    {
        if (Damage <= 0) 
        {
            destoyded();
        }
        Damage -= 1;
        updateText();
        randomColor();
    }

    void destoyded() 
    {
        blockSet.destroydedSquare();
        Destroy(gameObject);
    }
}
