using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;


    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }


    public TalkManager talkManager;
    public GameObject talkPanel;
    public Image portraitImg; 
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    public int talkCount;

    public void Action(GameObject scanObj)
    {
        /*
        if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            scanObject = scanObj;
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNpc); 
        }
        talkPanel.SetActive(isAction); 
        */

        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);

        talkPanel.SetActive(isAction); 
        
    }

    void Talk(int id,bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);


        if (talkData == null)
        {
            
            if(SceneManager.GetActiveScene().name == "Prologue")
            {
                SceneManager.LoadScene("Á¤¼÷");
            }

            if (SceneManager.GetActiveScene().name == "Chapter1-1")
            {
                SceneManager.LoadScene("Chapter1-2");
            }

            if (SceneManager.GetActiveScene().name == "Chapter1-2")
            {
                SceneManager.LoadScene("Chapter1-3");
            }

            if (SceneManager.GetActiveScene().name == "Chapter1-3")
            {
                SceneManager.LoadScene("Á¤´ë");
            }
            if (SceneManager.GetActiveScene().name == "Chapter2")
            {
                SceneManager.LoadScene("Choice");
            }
            if (SceneManager.GetActiveScene().name == "Chapter2-1")
            {
                SceneManager.LoadScene("Çö¸í");
            }
            if (SceneManager.GetActiveScene().name == "Chapter3-1")
            {
                SceneManager.LoadScene("Choice2");
            }
            if (SceneManager.GetActiveScene().name == "Chpater3-2")
            {
                SceneManager.LoadScene("Ending");
            }
            if (SceneManager.GetActiveScene().name == "Ending")
            {
                SceneManager.LoadScene("theEnd");
            }
            isAction = false;
            talkIndex = 0;
            

            return; 
        }

        if (isNpc)
        {
            talkText.text = talkData.Split(':')[0];
            portraitImg.sprite=talkManager.GetPortrait (id,int.Parse(talkData.Split(':')[1]));
            portraitImg.color = new Color(1, 1, 1, 1);
        }
        
        else
        {
            talkText.text = talkData;
            portraitImg.color = new Color(1, 1, 1, 0);
        }
        
        isAction = true;
        talkIndex++;
         

    }

}
