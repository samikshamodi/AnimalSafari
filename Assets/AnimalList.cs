using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class AnimalList : MonoBehaviour
{
   public void Back()
  {
       SceneManager.LoadScene(0);
  }
    public void Tiger()
  {
      SceneManager.LoadScene(2);
  }

  public void Dodo()
  {
      SceneManager.LoadScene(3);
  }

  public void Rhino()
  {
      SceneManager.LoadScene(4);
  }

   
}
