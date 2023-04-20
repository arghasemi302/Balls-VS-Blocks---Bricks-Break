using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Tooltip("the number you insert here will mines 1 because there is already on in the scene!!")]
    public int incNum = 10;
    private int stillBalls;

    public float waitBettwininc = 0.3f;
    public float forcePower = 180f;

    public Transform Ball;
    public Transform Rot;
    public Transform FirstBall;

    private void Start()
    {
        stillBalls = incNum;
    }

    public IEnumerator incBall() 
    {
        FirstBall.GetComponent<Rigidbody2D>().AddForce(Rot.up * forcePower);

        for (int i = 1; i < incNum; i++)
        {
            yield return new WaitForSecondsRealtime(waitBettwininc);

            Transform MakedBall = Instantiate(Ball, transform.position, Rot.rotation);
            MakedBall.GetComponent<Rigidbody2D>().AddForce(MakedBall.up * forcePower);
        }
    }

    public void checkWin()
    {
        if (blockSetNum.AliveSquares <= 0) 
        {
            win();
        }
    }

    void win() 
    {
        SceneManager.LoadScene(2);
        print("you Win!!");
        Time.timeScale = 0;
    }

    void CheckLose() 
    {
        stillBalls -= 1;

        if (stillBalls <= 0) 
        {
           Lose();
        }
    }

    void Lose() 
    {
        SceneManager.LoadScene(3);
        print("you lose!!");
        Time.timeScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            CheckLose();
            Destroy(collision.gameObject);
        }
    }
}
