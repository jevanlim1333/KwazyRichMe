using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havelock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openHavelock()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("havelock");
    }
    public void closeHavelock()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
