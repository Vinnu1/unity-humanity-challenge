using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC2 : NPC
{

    private string[] _dialogueList = {
        "Isn't it beautiful here?",
        "It is but please go above",
        "That's the plan",
        "I meant on the bridge",
        "There's nothing left to live..",
        "I'm sure there is, what's the problem",
        "I like a guy but my parents are against the marriage",
        "Why?",
        "They want a guy of our nationality",
        "And you can't marry this guy without your parents blessing?",
        "Right",
        "Your parents will be more hurt if you're no more than anything",
        "Try to convince them",
        "I've",
        "Then try some more",
        "...",
        "Ok"
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
            SceneManager.LoadScene("GamePart3");
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
