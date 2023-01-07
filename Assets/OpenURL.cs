using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void openBinusmaya()
    {
        Application.OpenURL("https://binusmaya.binus.ac.id/newDefault/login.html");
    }

    public void openBluejack()
    {
        Application.OpenURL("https://bluejack.binus.ac.id/prk/auth/login");
    }

    public void openSSC() 
    {
        Application.OpenURL("https://linktr.ee/contactssc");
    }

    public void openLSC()
    {
        Application.OpenURL("https://linktr.ee/contactlsc");
    }
}
