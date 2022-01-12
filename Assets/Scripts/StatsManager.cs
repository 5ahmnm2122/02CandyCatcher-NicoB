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

    public string userName;
    public int score;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void CheckName()
    {
        GameObject.Find("btn_start").GetComponent<Button>().interactable =
            GameObject.Find("if_name").GetComponent<InputField>().text.Length >= 4 ? true : false;
        userName = GameObject.Find("if_name").GetComponent<InputField>().text;
    }
}