using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tigerController : MonoBehaviour
{
    private Rigidbody rb;
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        anim=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    public void nextAnimal()
    {
        SceneManager.LoadScene(1);
    }

    public void rescanAnimal()
    {
         

    }

    public void prevAnimal()
    {
        SceneManager.LoadScene(2);
    }

     public void run()
    {
     anim.Play("run");
    }

    public void hit()
    {
     anim.Play("hit");
    }

    public void idle()
    {
     anim.Play("idle");
    }

    public void roar()
    {
     anim.Play("sound");
    }

    public void walk()
    {
        anim.Play("walk");
    }




}