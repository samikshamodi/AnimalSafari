using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRoar : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource roarSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playRoar()
    {
        roarSound.Play();
    }
}
