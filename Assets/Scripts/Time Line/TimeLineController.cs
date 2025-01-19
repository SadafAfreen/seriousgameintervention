using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine;

public class TimeLineController : MonoBehaviour
{   
    public PlayableDirector playableDirector;

    public void Play()
    {
        playableDirector.Play();
    }
}
