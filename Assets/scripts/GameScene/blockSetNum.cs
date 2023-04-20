using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSetNum : MonoBehaviour
{
    public int minDamage;
    public int maxDamage;
    public static int AliveSquares;

    private square[] Squares;

    private GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();

        AliveSquares = transform.childCount;
        Squares = new square [transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            Squares[i] = transform.GetChild(i).GetComponent<square>();
            int randomDamage = Random.Range(minDamage, maxDamage);

            Squares[i].Damage = randomDamage;
        }
    }

    public void destroydedSquare() 
    {
        AliveSquares -= 1;
        gameManager.checkWin();
    }

}
