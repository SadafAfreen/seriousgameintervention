using UnityEngine;

public class ItemInteraction : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        VoiceDialoge();
    }

    void VoiceDialoge()
    {
        Debug.Log("Sound Played for " + item.name);
        FindObjectOfType<AudioManager>().Play("Chair");
        

        //Add particle affect to the object
    }
}
