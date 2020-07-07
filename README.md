To record video of the game I recommend using Unity's preview recorder package which can be found in the package manager. 

Recording resolution I used was 1624x750 this gave me good visual quality whilst keeping the video file reasonably small


Make sure the video is recorded with audio

In order to have the audio play, there has to be an input from the user.
This can be done in a few ways, in this template i have just decided to unmute the video player on first input since the only audio i have is a jump sound.

If you have music or ambient sounds right from the start of the video, i would recommend adding in a "tap to start" so that you get that first input immediately which in turn will
allow you to play audio from the video

In order to unmute the video use VIDEOPLAYER.SetDirectAudioMute(0,false); 
To mute use VIDEOPLAYER.SetDirectAudioMute(0,true);