using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float force;
   

    Rigidbody2D PlayerRigid;

    public GameObject RestartButton;
    public GameObject HomeButton;
    public AudioSource jump;
    public AudioSource fail;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PlayerRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (PlayerPrefs.GetString("sound") == "Yes")
                jump.Play();
            
            PlayerRigid.velocity = Vector2.up * force; 
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "tube")
        {
           if (PlayerPrefs.GetString("sound") == "Yes")
                fail.Play();
          
            Time.timeScale = 0;
            RestartButton.SetActive(true);
            HomeButton.SetActive(true);
        
        }
    }
}
