using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
