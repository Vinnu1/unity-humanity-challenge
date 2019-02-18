using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC3 : NPC
{

    private string[] _dialogueList = {
        "Not much, what are you doing here",
        "Came to end it all today man",
        "Why?",
        "I don't know mate, nothing really matters in the bigger picture",
        "We all are just a very small part of this universe man",
        "I believe we're all a very important part of this world",
        "You know what I'm talking about",
        "I'm the perfect dude, I've everything but still I feel empty",
        "Nothing I'll ever do will change the universe, is there anyone except us here",
        "Are you happy with the way world is currently, are there no problems?",
        "Sure they are",
        "Then why don't you fix them, we need you",
        "Maybe you're right, you talk sense man, have you lost someone",
        "Yea..h. my colleague gave up life to this disease",
        "You think you're responsible?",
        "I do feel guilty, maybe I could've do more, stop him, protected him from the press",
        "The way you talk man, I think you did everything you could've",
        "You talk sense into me, so let me to you, it wasn't your fault",
        "Let's both go home",
        "Right"
    };
    private int _currentD = 0;
    public Text Text;


    public override void Init()
    {
        base.Init();
    }

    public override void Movement()
    {
        base.Movement();

    }

    public void NextDialogue()
    {
        if (_dialogueList.Length == _currentD)
        {
            SceneManager.LoadScene("Credits");
        }
        else
        {
            Text.text = _dialogueList[_currentD];
            _currentD++;
        }

    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
    }

    public override void OnTriggerExit2D(Collider2D other)
    {
        base.OnTriggerExit2D(other);
    }

}
