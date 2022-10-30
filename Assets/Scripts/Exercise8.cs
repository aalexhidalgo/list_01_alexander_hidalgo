using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise8 : MonoBehaviour
{
    public TextMeshProUGUI enterText;
    public TMP_InputField usernameText;

    public void ConfirmButton()
    {
        /*This avoid empty usernames and blanks spaces
        as a username but let players to do a blank space between letters,
        with results like: alexhidalgo, alex hidalgo or a l e x*/

        if(string.IsNullOrWhiteSpace(usernameText.text))
        {
            enterText.text = "¡Empty username! Please fill correctly the box";
        }
        else
        {
            enterText.text = $"¡Hello {usernameText.text} and welcome to this wonderful world!";
        }
    }
}
