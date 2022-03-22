using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int p1Score;
    private int p2Score;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        p1Score = 0;
        p2Score = 0;

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

    private void UpdateP1Score(int p1ScoreToAdd)
    {
        p1Score = p1Score + p1ScoreToAdd;
        p1ScoreText.text = "P1 Score: " + p1Score;
    }

    private void UpdateP2Score(int p2ScoreToAdd)
    {
        p2Score = p2Score + p2ScoreToAdd;
        p2ScoreText.text = "P2 Score: " + p2Score;
    }
}
