using UnityEngine;
 
public class reticle : MonoBehaviour 
{
    public Texture2D crosshairTexture; 
    public Rect position; 
    static bool OriginalOn = true;
 
    void Start() 
    {
        position = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height - crosshairTexture.height) /2, crosshairTexture.width, crosshairTexture.height);
    }
 
    void OnGUI() 
    { 
        if(OriginalOn) GUI.DrawTexture(position, crosshairTexture); 
    }
}