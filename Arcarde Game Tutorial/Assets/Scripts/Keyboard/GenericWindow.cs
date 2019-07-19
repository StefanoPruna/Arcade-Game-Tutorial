using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericWindow : MonoBehaviour
{
    public GameObject firstSelected;

    protected UnityEventQueueSystem eventSystem
    {
        get { return GameObject.Find("ClicktoContinue").GetComponent<UnityEventQueueSystem>(); }
    }

    public void OnApplicationFocus(bool focus)
    {
        eventSystem.Equals (firstSelected);
    }

    protected void Display(bool value)
    {
        gameObject.SetActive(value);
    }

    public void Open()
    {
        Display(true);
        OnApplicationFocus();
    }

    private void OnApplicationFocus()
    {
        throw new NotImplementedException();
    }

    public void Close()
    {
        Display(false);
    }

    protected virtual void Awake() //with wirtual we can change in a child class
    {
        Close();
    }

}
