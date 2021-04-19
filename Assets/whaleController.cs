using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleController : MonoBehaviour
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

    
      public void swim()
    {
     anim.Play("swim");
    }


    public void fastswim()
    {
     anim.Play("fastswim");
    }

    public void death()
    {
     anim.Play("death");
    }

    public void fastswim2()
    {
     anim.Play("fastswim2");
    }

    public void dive()
    {
     anim.Play("dive");
    }
}
