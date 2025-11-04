using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wlynn_gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public wlynn_goalscript blue, red, green, orange;
    public TextMeshProUGUI youWin;
    public int timerSecond = 0;
    public int timerMinute = 0;
    public bool gameOver = false;
    float temp;
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == false)
        {
            temp += Time.deltaTime;
            timerMinute = Mathf.FloorToInt(temp / 60);
            timerSecond = Mathf.FloorToInt(temp - timerMinute * 60);
            print(timerSecond);
        }
        
        if (blue.isSolved && red.isSolved && orange.isSolved && green.isSolved)
        {

            
            gameOver = true;
            youWin.text = "YOU WIN! Time: " +timerMinute + ":" + timerSecond;

        }
    }
}
