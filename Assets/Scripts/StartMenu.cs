using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.anyKey)
        {
            StartButton();
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Story");
    }

}
