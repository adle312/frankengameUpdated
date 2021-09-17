using System.Collections;                                                                                                                                                                                      using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheMainCharacter : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float playerSpeed = 8.0f;
    public float jumpspeed = 0.5F;
    //public Camera playercam;

    //public bool IsLanding = false;
    public static int numberofjump = 0;
    public bool doublejumpallow = false;
   


    // Start is called before the first frame update
    void Start()
    {
        playerRB = transform.GetComponent<Rigidbody2D>();
        // = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
      

    
        
        Vector3 playermoving = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += playermoving * Time.deltaTime * playerSpeed;

        if (Input.GetButtonDown("Jump") && numberofjump <2)
        {

            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpspeed);
            numberofjump = numberofjump + 1;
            //doublejumpallow = true;
           
            //doublejump = true;
        }

     

        //Xdirection = Input.GetAxis("Horizontal") * playerSpeed;

        
    }
    


    public void OnCollisionEnter2D(Collision2D gameoverx)
    {
        if(gameoverx.gameObject.name == "theDeath")
        {
            SceneManager.LoadScene("GGscene");
        } 
    }

    

  


    
}
