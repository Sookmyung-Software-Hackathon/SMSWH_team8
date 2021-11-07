using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoader5 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Game Over");
    }
}
