using UnityEngine;
using System.Collections;

public class beweging : MonoBehaviour
{
    public float speed = 10f; // Code for how fast the ball can move. Also it will be public so we can change it inside of Unity itself. 
    public Rigidbody player1RB; //Player 1 Rigidbody
    


    //Player 1 Code with aswd keys
    void Player1Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(Vector3.back * speed * Time.deltaTime);

        }

		if (transform.position.y < -10){
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			transform.position = new Vector3(5, 2, 8);
			transform.rotation = new Quaternion(0, 0, 0, 0);
			
		}
    }

    //Player 2 Code with arrow keys
   

    // Update is called once per frame
    void FixedUpdate()
    {
        Player1Movement();
        
    }
}
