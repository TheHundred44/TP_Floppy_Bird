using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    public GameObject LoseInterface;
    public GameObject StartInterface;

    [SerializeField]
    private DeadZone _deadZone;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        _deadZone.OnDead += LoseInterfaceActive;
    }

    public void StartGame()
    {
        StartInterface.SetActive(false);
        Time.timeScale = 1;
    }

    public void LoseInterfaceActive()
    {
        LoseInterface.SetActive(true);
    }

    public void SceneRestart()
    {
        SceneManager.LoadScene("FloppyGame");
    }
}
