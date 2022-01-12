using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    #region Singleton
    private static CanvasManager instance;

    public static CanvasManager Instance
    {
        get { return instance; }
    }
    #endregion
    void Awake()
    {
        if (instance == null)
            instance = this;
        try
        {
            name.text = StatsManager.Instance.userName;
        }
        catch
        {
            name.text = "Joe";
            Debug.LogWarning("Start from first scene!");
        }
    }

    public Text name;
    public Text score;
    [SerializeField]
    Text time;

    float timeRemaining = 60;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        time.text = Mathf.Floor(timeRemaining).ToString();
        if (timeRemaining <= 0)
            SceneManager.Instance.PendLoadScene(2);
    }
}
