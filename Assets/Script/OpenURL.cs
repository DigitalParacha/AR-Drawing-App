using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=61564258543995");
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/awgzo/");
    }
    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/company/awgzo/");
    }
    public void Whatsapp()
    {
        Application.OpenURL("https://www.whatsapp.com/channel/0029VaoIVR3Fsn0WEndi6C0i");
    }
    public void Consultation()
    {
        Application.OpenURL("https://calendly.com/ahmedwaleed-paracha/30min");
    }
    public void Website()
    {
        Application.OpenURL("https://awgzo.com/");
    }
}
