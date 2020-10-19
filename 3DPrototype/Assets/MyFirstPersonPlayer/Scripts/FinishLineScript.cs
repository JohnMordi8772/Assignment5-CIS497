/** John Mordi* 
 * Assignment#5 - 3D Prototype* 
 * Checks to see if player reaches the finish and displays victory text*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    public Text finishText;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            finishText.text = "You Win!";
        }
    }
}
