using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("basladý");
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
