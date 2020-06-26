using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    [SerializeField] private PlaygroundFields pgFields;
    
    [SerializeField] private GameObject endScreen;
    
    [SerializeField] private VideoPlayer videoPlayer;

    [SerializeField] private Stop[] stops;

    
    [SerializeField] private GameObject tutorialOverlay;
    [SerializeField] private Text tutorialText;
    private int stopIndex = 0;

    private bool hitStoppingPoint = false;
    
    #if UNITY_EDITOR
    //Simple method to set the values in the PlaygroundFields scriptable object to the values inside of the stops array
    //call this method if you've changed the values in the stops array to assign those changes as the default playground field values
    [ContextMenu("Set Times")]
    void SetPlaygroundStopTimes()
    {
        pgFields.stop0 = stops[0].stopTime;
        pgFields.stop1 = stops[1].stopTime;
        pgFields.stop2 = stops[2].stopTime;
        pgFields.stop3 = stops[3].stopTime;
    }
    #endif
    
    void Start()
    {
        //Set each stop to the value input in Playground
        stops[0].stopTime = pgFields.stop0;
        stops[1].stopTime = pgFields.stop1;
        stops[2].stopTime = pgFields.stop2;
        stops[3].stopTime = pgFields.stop3;

        tutorialText.text = pgFields.tutorialString;
        tutorialText.color = pgFields.tutorialTextColour;
        
        //Subscribe to loopPointReached for when the video ends
        videoPlayer.loopPointReached += DisableInput;
    }
    
    void DisableInput(VideoPlayer videoPlayer)
    {
        //enable the end screen and disable the videoController gameObject as its not needed any more
        endScreen.SetActive(true);
        gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        CheckForStop();

        CheckForInput();
    }

    void CheckForInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (videoPlayer.isPaused)
            {
                videoPlayer.Play();
                tutorialOverlay.SetActive(false);
                hitStoppingPoint = false;
            }
        }
    }

    void CheckForStop()
    {
        if (stopIndex <= stops.Length-1)
        {
            if (stops[stopIndex].index == stopIndex)
            {
                if (videoPlayer.time >= stops[stopIndex].stopTime)//Are we at the correct point in the video
                {
                    PauseVideo(); //Pause the video if stops[stopIndex].stopTime matches the video players current time 
                }
            }
        }
    }

    void PauseVideo()
    {
        if (!videoPlayer.isPaused)
        {
            videoPlayer.Pause();
            tutorialOverlay.SetActive(true);
            hitStoppingPoint = true;
            stopIndex++;
        }
    }

    public void TryPlayVideo()
    {
        if (!hitStoppingPoint)
        {
            videoPlayer.Play();
        }
    }
    public void TryPauseVideo()
    {
        if (!hitStoppingPoint)
        {
            videoPlayer.Pause();
        }
    }

}

[System.Serializable]
public class Stop
{
    public float stopTime;
    public int index;
}