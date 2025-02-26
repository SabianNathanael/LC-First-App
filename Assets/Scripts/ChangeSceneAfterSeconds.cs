using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    public LoadScene ls;
    public float second;
    public string scenename;
    void Start()
    {   
        Invoke("ChangeAfterSeconds", second);
    }

    // Update is called once per frame
    public void ChangeAfterSeconds()
    {
        ls.ChangeScene(scenename);
    }
}
