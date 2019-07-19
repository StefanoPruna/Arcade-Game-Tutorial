using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public Text inputField;
    public int maxCharacters = 7;

    private float delay = 0;
    private float curseDelay = .5f;
    private bool blink;
    private string _text = "";

    private void Update()
    {
        var text = _text;
        if (_text.Length <maxCharacters)
        {
            text += "_";
            if(blink)
            {
                text = text.Remove(text.Length - 1);
            }
        }

        inputField.text = text;
        delay += Time.deltaTime;
        if(delay> curseDelay)
        {
            delay = 0;
            blink = !blink;
        }
    }

    public void OnKeyPress(string key)
    {
        if(_text.Length <maxCharacters)
        {
            _text += key;
        }
    }
}
