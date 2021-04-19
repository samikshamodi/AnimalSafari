using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penguinController : MonoBehaviour
{
     private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
          anim=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void run()
    {
     anim.Play("run");
    }


    public void idle()
    {
     anim.Play("idle");
    }


    public void walk()
    {
        anim.Play("walk");
    }
}
