using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip audioclip;

    [Range(0f, 1f)]
    public float volumn;
    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

}
