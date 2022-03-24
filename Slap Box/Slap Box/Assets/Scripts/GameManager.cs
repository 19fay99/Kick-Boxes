using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int p1Score = 0;
    public int p2Score = 0;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        UpdateP1Score(0);
        UpdateP2Score(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Game Closed");
        }
    }

    public void UpdateP1Score(int p1ScoreToAdd)
    {
        p1Score = p1Score + p1ScoreToAdd;
        p1ScoreText.text = "P1 Score: " + p1Score;
    }

    public void UpdateP2Score(int p2ScoreToAdd)
    {
        p2Score = p2Score + p2ScoreToAdd;
        p2ScoreText.text = "P2 Score: " + p2Score;
    }
}
