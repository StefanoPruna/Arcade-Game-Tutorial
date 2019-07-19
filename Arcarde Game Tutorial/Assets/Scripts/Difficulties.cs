using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulties : MonoBehaviour
{
    public void OnDrawGizmosSelected()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            OnDrawGizmosSelected();
        }
    }
}
