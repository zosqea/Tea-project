using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage : MonoBehaviour
{

    public int stageNumber;
    public GameObject boiling;
    public GameObject poinZero;
    public bool kittleExists = false;
    public bool boilingProgrss = false;
    public GameObject boilingProcess;
    public GameObject kittleGO;
    public GameObject cup;
    void Start()
    {
        kittleGO = GameObject.Find("kittle(Clone)");
        boilingProcess.SetActive(false);
    }
    void Update()
    {
        //if (!kittleExists)
        //{
        //    Instantiate(boiling, poinZero.transform.position, Quaternion.identity, poinZero.transform);
        //    kittleExists = true;
        //}
        //��� ���� �� ����� switch (stage)
        if (stageNumber==1)
        {
            boilingProcess.SetActive(true);
            
            if (Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.LeftControl)&&Input.GetKey(KeyCode.RightShift))
            {
                stageNumber++;
            }
        }
        else
        {
            boilingProcess.SetActive(false);
        }
        if (stageNumber == 2)
        {
            SceneManager.LoadScene("mumble");
        }

    }
    public void boilingBoolTrue()
    {
        boilingProgrss = true;
    }    
    public void boilingBoolFalse()
    {
        boilingProcess.SetActive(false);
        stageNumber = 0;
        //��� ������ ���� �������� � ���������� ���
    }
    //public void travka()
    //{
    //    stageNumber = 2;
    //}
}

    
