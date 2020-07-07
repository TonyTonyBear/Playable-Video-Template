## What is a Playable Video?

A Playable Video is an interactive ad, which is served as a playable ad (HTML). 

A video is played in Unity and can be interacted with (paused/played/changed) via user input. 

In Unity you can layer on animations and UI, to provide a more engagening user experience. 

## How to use this template

(2019.2.19 was used to create this version)

To record video of the game we recommend using Unity's preview recorder package which can be found in the package manager. 

If you want to support portait and landscape, you can record using a resolution of 1624x750.
This gives good visual quality whilst keeping the video file reasonably small.

* Make sure the video is recorded with audio


## Video Audio

In order to have the audio play, there has to be an input from the user. This is policy related. 

This can be done in a few ways. In this template we unmute the video player on first input.

If you have music or ambient sounds from the start of the video, it is recommended to add a "tap to start" functionaliy so that you get that first input immediately which in turn will allow you to play audio from the video.

In order to unmute the video use `VIDEOPLAYER.SetDirectAudioMute(0,false);`
To mute use `VIDEOPLAYER.SetDirectAudioMute(0,true);`
