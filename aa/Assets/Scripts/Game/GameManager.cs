using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainCircle;
    public GameObject spawner;


    public void GameOver()
    {
        Debug.Log("bitti");
        mainCircle.GetComponent<Spin>().enabled = false;
        spawner.GetComponent<Spawner>().enabled = false;
       //ime.timeScale = 0;

    }


}
