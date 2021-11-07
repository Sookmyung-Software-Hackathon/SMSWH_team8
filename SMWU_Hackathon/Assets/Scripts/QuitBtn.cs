using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitBtn : MonoBehaviour
{
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Quit Button Click");
    }
}
