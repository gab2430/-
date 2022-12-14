using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static int score;
    public float limittime = 20.0f;
    public Text timerText;
    public Text scoreText;
    public bool isTimeUp;
    // Start is called before the first frame update

    public static int getscore()
    {
        return score;
    }
    void Start()
    {
        score = 0;
        isTimeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "    " + score;
        //制限時間との差を取得し続ける
        limittime -= Time.deltaTime;
        //文字列に変換して表示
        timerText.text = "Time: " + limittime.ToString("F1");

        if (0 >= limittime)
        {
            timerText.text = "0";
        }
        if (-1 >= limittime)
        {
            SceneManager.LoadScene("result");
        }

        if (Input.GetMouseButtonDown(1))
        {
            score += 100;
        }
    }
}
