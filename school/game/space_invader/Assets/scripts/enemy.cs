using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public float health = 150f;
    public GameObject laser;
    public float lasersnelheid;
    public float shotsPerSeconds = 0.3f;

    public AudioClip FireSound;
    public AudioClip DeathSound;

    private ScoreKeeper _scoreKeeper;
    public int ScoreValue = 10;



    // Use this for initialization

    private void Start()
    {
        _scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Projectile missile = col.GetComponent<Projectile>();
        if (missile)
        {
            health -= missile.GetDamage();
            if (health <= 0)
            {
                Die ();
            }
            missile.Hit();
        }
    }
    void Die()
    {
        AudioSource.PlayClipAtPoint(DeathSound, transform.position);
        Destroy (gameObject);
        _scoreKeeper.ScoreUp(ScoreValue);
    }
       
    void Fire()
    {
        GameObject beam = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
        AudioSource.PlayClipAtPoint(FireSound, transform.position);
        beam.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -lasersnelheid);
    }

    private void Update()
    {
        float mogelijkheid = Time.deltaTime * shotsPerSeconds;
        if (Random.value < mogelijkheid)
        {
            Fire();
        }
    }
}
