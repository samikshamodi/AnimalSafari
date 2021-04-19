using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class penguinButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void nextAnimal()
    {
        SceneManager.LoadScene(2);
    }

        public void prevAnimal()
    {
        SceneManager.LoadScene(0);
    }
}
