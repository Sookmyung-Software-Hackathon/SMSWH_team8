using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Start");
    }
}
