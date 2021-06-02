using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LinkedIn()
    {
        Application.OpenURL("https://linkedin.com/in/carmurrain");
    }

    public void GitHub()
    {
        Application.OpenURL("https://github.com/CrispthoAlex");
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/CrispthoAlex");
    }

    public void Email()
    {
        Application.OpenURL("mailto:ing.alexander-murrain@hotmail.es");
    }
}
