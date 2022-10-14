using UnityEngine;
using System.Collections;

public class beweegscript : MonoBehaviour
{
    public float speed = 10f; // Code for how fast the ball can move. Also it will be public so we can change it inside of Unity itself. 
    public Rigidbody player1RB; //Player 1 Rigidbody
    GameObject s1;
	GameObject s2;
	TextMesh t1;
	TextMesh t2;
	int p1 = 0;
	int p2 = 0;

	void Start(){
		s1 = GameObject.Find("player1RB");
		s2 = GameObject.Find("player2RB");
		t1 = GameObject.Find("t1").GetComponent<TextMesh>();
		t2 = GameObject.Find("t2").GetComponent<TextMesh>();
		t1.text = "Score Rood: " + p1.ToString();
		t2.text = "Score Blauw: " + p2.ToString();




	}
    //Player 1 Code with aswd keys
    void Player1Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            s1.transform.Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            s1.transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.W))
        {
            s1.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            s1.transform.Translate(Vector3.back * speed * Time.deltaTime);

        }

		if (Input.GetKey(KeyCode.LeftArrow))
        {
            s2.transform.Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            s2.transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            s2.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            s2.transform.Translate(Vector3.back * speed * Time.deltaTime);

        }

		
		if (s1.transform.position.y < -10){
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			s1.transform.position = new Vector3(-5, 2, -8);
			s2.transform.position = new Vector3(5, 2, 8);
			transform.rotation = new Quaternion(0, 0, 0, 0);
			p2++;


			t1.text = "Score Rood: " + p1.ToString();
			t2.text = "Score Blauw: " + p2.ToString();
			
		}
		if (s2.transform.position.y < -10){
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			s1.transform.position = new Vector3(-5, 2, -8);
			s2.transform.position = new Vector3(5, 2, 8);
			transform.rotation = new Quaternion(0, 0, 0, 0);
			p1++;


			t1.text = "Score Rood: " + p1.ToString();
			t2.text = "Score Blauw: " + p2.ToString();
			
		}
    }



    //Player 2 Code with arrow keys
   

    // Update is called once per frame
    void FixedUpdate()
    {
        Player1Movement();
        
    }
}
