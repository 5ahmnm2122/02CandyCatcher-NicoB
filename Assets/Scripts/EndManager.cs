using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    [SerializeField]
    Text stats;

    void Start()
    {
        FillInValues();
        Cursor.lockState = CursorLockMode.None;
    }

    public void FillInValues()
    {
        string final = StatsManager.Instance.userName + "\n" + StatsManager.Instance.score + "\n\n";
        final = StatsManager.Instance.score <= 20 ? final += "You lost, try again!" : final += "Good job, you won!";
        stats.text = final;
    }

    public void Restart()
    {
        SceneManager.Instance.PendLoadScene(0);
    }
}
