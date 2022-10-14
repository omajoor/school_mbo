using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    // Use this for initialization
    private float _stuur;
    private float _xmin;
    private float _xmax;


    public AudioClip FireSound;
    public AudioClip DeathSound;

    public GameObject laser;
    public float straalsnelheid;
    public float vuurRate;
    public float health = 350f;

    public float Padding = 0.7f;
    public float Snelheid;

    private healthbar _healthbar;

   
    public int healthValue = -50;
    void Start () {

        _healthbar = GameObject.FindObjectOfType<healthbar>();
        float distance = transform.position.x - Camera.main.transform.position.z;
        Vector3 meestlinks = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 meestrechts = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

        _xmin = meestlinks.x + Padding;
        _xmax = meestrechts.x - Padding;

        


    }
	
	// Update is called once per frame
	void Update () {
        _stuur = Mathf.Clamp((_stuur += Input.GetAxis("Horizontal") * Time.deltaTime * Snelheid), _xmin, _xmax);
        transform.position = new Vector2(_stuur, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
             InvokeRepeating ("Fire", 0.000001f, vuurRate);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke("Fire");
        }

        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Projectile missile = col.GetComponent<Projectile>();
        if (missile)
        {
            health -= missile.GetDamage();
            
            if (health <= 0)
            {
                Die();
            }
            missile.Hit();
            _healthbar.healthmeter(health);
        }
    }
    void Fire()
    {
        Vector3 startPositie = transform.position + new Vector3(0, 1.2f, 0);
        GameObject straal = Instantiate(laser, startPositie, Quaternion.identity) as GameObject;
        AudioSource.PlayClipAtPoint(FireSound, transform.position);
        straal.GetComponent<Rigidbody2D>().velocity = new Vector3(0, straalsnelheid, 0);
    }
    void Die()
    {
        AudioSource.PlayClipAtPoint(DeathSound, transform.position);
        Destroy(gameObject);
        SceneManager.LoadScene("lose");
        
    }

    
}
 
