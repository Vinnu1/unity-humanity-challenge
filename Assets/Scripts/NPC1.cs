using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC1 : NPC
{
    private string[] _dialogueList = {
        "I know",
        "Try to go above",
        "Nope, came to fall to heaven",
        "I know life is tough, but this isn't right",
        "I don't know what right is anymore",
        "I can listen to what you've to say",
        "Well.. I'm in student debt, will get a useless degree in English..",
        "I don't even know how many years it will take to repay the loan",
        "My parents already have financial issues of their own",
        "I'm better this way...",
        "No, you're not. English isn't a useless degree",
        "Many countries with other native languages, require english lecturers",
        "They pay pretty handsome salary too",
        "I don't know the details but it's worth a try",
        "I know you don't want to do this man",
        "I guess it is worth a try...",
        "Go above, I'll help you"
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
            SceneManager.LoadScene("GamePart2");
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
