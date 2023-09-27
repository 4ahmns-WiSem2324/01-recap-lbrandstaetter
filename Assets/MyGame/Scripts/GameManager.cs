using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float maxtime = 3.1f;
    public Text targetNumberText;
    private float countdownTimer;
    public int targetNumber;
    public bool gameStarted = false;
    public Text countTxt;

    private bool keypad1 = false;
    private bool keypad2 = false;
    private bool keypad3 = false;
    private bool keypad4 = false;
    private bool keypad5 = false;
    private bool keypad6 = false;
    private int spaceInt = 0;
    private int score = 0;
    private float waitSeconds;

    private void Start()
    {

        countdownTimer = maxtime;
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            keypad1 = true;
        }
        else
        {
            keypad1 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            keypad2 = true;
        }
        else
        {
            keypad2 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            keypad3 = true;
        }
        else
        {
            keypad3 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            keypad4 = true;
        }
        else
        {
            keypad4 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            keypad5 = true;
        }
        else
        {
            keypad5 = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            keypad6 = true;
        }
        else
        {
            keypad6 = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceInt = 9;
        }
        else
        {
            spaceInt = 0;
        }

        if (gameStarted)
        {

            countdownTimer -= Time.deltaTime;

            if (keypad1 == true && targetNumber == 1 ||
                keypad2 == true && targetNumber == 2 ||
                keypad3 == true && targetNumber == 3 ||
                keypad4 == true && targetNumber == 4 ||
                keypad5 == true && targetNumber == 5 ||
                keypad6 == true && targetNumber == 6)
            {
                StartGame();
                score++;
            }
            else if (keypad1 == true && targetNumber != 1 ||
                    keypad2 == true && targetNumber != 2 ||
                    keypad3 == true && targetNumber != 3 ||
                    keypad4 == true && targetNumber != 4 ||
                    keypad5 == true && targetNumber != 5 ||
                    keypad6 == true && targetNumber != 6)
            {
                targetNumber = 9;
                targetNumberText.text = "Press Space to Restart";
                countTxt.text = "" + score;
            }


            if (countdownTimer <= 0)
            {
                targetNumberText.text = "888";
                targetNumber = 9;

            }
            if (spaceInt == targetNumber)
            {
                StartGame();
                maxtime = 3.1f;
                countdownTimer = 3;
            }
        }
    }

    private void StartGame()
    {

        targetNumber = Random.Range(1, 7);


        targetNumberText.text = "" + targetNumber;


        if (maxtime >= 0.8f)
        {
            maxtime -= 0.05f;
        }

        countdownTimer = maxtime;

        gameStarted = true;
    }
}