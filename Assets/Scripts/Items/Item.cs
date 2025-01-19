using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "Environment Objects/Item")]
public class Item : ScriptableObject
{
    new public string name = "New name";
    public AudioClip audioClip = null;
}
