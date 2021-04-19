using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class whaleButtons : MonoBehaviour
{
      public void nextAnimal()
    {
        SceneManager.LoadScene(0);
    }

        public void prevAnimal()
    {
        SceneManager.LoadScene(1);
    }
}
