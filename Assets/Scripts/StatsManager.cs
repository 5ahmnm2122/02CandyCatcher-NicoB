using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{
    #region singleton
    private static StatsManager instance;
    public static StatsManager Instance
    {
        get { return instance; }
    }
    #endregion

    string userName;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void CheckName()
    {
        if (GameObject.Find("if_name").GetComponent<InputField>().text.Length <= 4)
            GameObject.Find("btn_start").GetComponent<Button>().enabled = true;
        else
            GameObject.Find("btn_start").GetComponent<Button>().enabled = false;
        userName = GameObject.Find("if_name").GetComponent<InputField>().text;
    }

    public void SetStats()
    {
        // TODO
    }
}