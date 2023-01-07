using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PostToGform : MonoBehaviour
{
    public InputField name;
    public InputField phoneNumber;
    public InputField email;
    

    string FormURL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfqZZlW5IWzVLhQzxU5dl9m1LtzVAX_LiusGOuBIWLiynkrbQ/formResponse";
    string entryName = "entry.1957923479";
    string entryPhone = "entry.932641555";
    string entryEmail = "entry.66284921";

    public void SendData()
    {
        StartCoroutine(Post(name.text, phoneNumber.text, email.text));
    }

    IEnumerator Post(string name, string phone_number, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField(entryName, name);
        form.AddField(entryPhone, phone_number);
        form.AddField(entryEmail, email);


        UnityWebRequest www = UnityWebRequest.Post(FormURL, form);

        yield return www.SendWebRequest();
    }
}
