using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    #region singleton
    private static SceneManager instance;
    public static SceneManager Instance
    {
        get { return instance; }
    }

    #endregion
    void Awake()
    {
        if (instance == null)
            instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeScene(int index)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }

    public void PendLoadScene(int index)
    {
        if (index == 1)
        {
            ChangeScene(1);
        }
        if (index == 2)
        {
            ChangeScene(2);
        }
        if (index == 0)
        {
            ChangeScene(0);
            Destroy(this);
        }
    }
}
