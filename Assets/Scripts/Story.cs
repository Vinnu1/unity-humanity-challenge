//Attach this script to an Image GameObject and set its Source Image to the Sprite you would like.
//Press the space key to change the Sprite. Remember to assign a second Sprite in this script's section of the Inspector.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    Image img;
    //Set this in the Inspector
    public Sprite letterImage;

    void Start()
    {
        //Fetch the Image from the GameObject
        img = GetComponent<Image>();
    }

    void Update()
    {
        //Press space to change the Sprite of the Image
        if (Input.anyKeyDown)
        {   
            if(img.sprite == letterImage)
            {
                SceneManager.LoadScene("GamePart1");
            }
            else
            {
                img.sprite = letterImage;
            }
        }
    }
}