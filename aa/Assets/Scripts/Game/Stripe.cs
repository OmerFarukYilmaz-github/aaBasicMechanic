using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stripe : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed;
    private bool canIt_move=true;
    public GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Gm");
    }

    // Update is called once per frame
    void Update()
    {
        if (canIt_move)
        {
            rb2D.MovePosition(rb2D.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       
        if(col.gameObject.tag =="MainCircle")
        {
            //Deðdiðinin child ol
            transform.SetParent(col.transform); 
            canIt_move = false;
        }

        if (col.gameObject.tag == "StripeHead")
        {
            Debug.Log("Bitmesi Gerek");
            gm.GetComponent<GameManager>().GameOver();
            SceneManager.LoadScene(0);
        }


    }


}
