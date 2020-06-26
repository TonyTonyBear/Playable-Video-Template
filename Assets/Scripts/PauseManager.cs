using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private VideoController vidController;
    void Start()
    {
        Luna.Unity.LifeCycle.OnResume += Resume;
        Luna.Unity.LifeCycle.OnPause += Pause;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        vidController.TryPlayVideo();
    }

    private void Pause()
    {
        Time.timeScale = 0;
        vidController.TryPauseVideo();
    }

}
