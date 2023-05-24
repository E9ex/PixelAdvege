using UnityEngine;
using UnityEngine.InputSystem;
public class moveplayer : MonoBehaviour
{
   
    // Update is called once per frame
    void FixedUpdate()
    {
    
    }

    void flip()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            transform.Rotate(0,180,0);
        }
    } 
}
