using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loyang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openLoyang()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("loyang");
    }
    public void closeLoyang()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
