using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour {
    public GameObject enemyPrefab;

    public float width = 10f;
    public float height = 5f;

    private bool movingRight = true;
    public float speed = 5f;

    private float _xmin;
    private float _xmax;
    public float spawnDelay = 0.5f;
    

    bool AllMembersDead()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }
    Transform NextFreePosition()
    {
        foreach (Transform childPositionGameObject in transform)
        {
            if (childPositionGameObject.childCount == 0)
            {
                return childPositionGameObject;
            }
        }
        return null;
    }

    void SpawnUntilFull()
    {
        Transform freePosition = NextFreePosition();
        if (freePosition)
        {
            GameObject enemy = Instantiate(enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }
        if (NextFreePosition())
        {
            Invoke("SpawnUntilFull", spawnDelay);
        }
    }


    // Use this for initialization
    void Start() {

        foreach (Transform child in transform)
        {
            GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity);
            enemy.transform.parent = child;
        }
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightBoundary = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        _xmin = leftBoundary.x;
        _xmax = rightBoundary.x;
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        float rightEdgeFormation = transform.position.x + (0.5f * width);
        float leftEdgeFormation = transform.position.x - (0.5f * width);
        
        if (leftEdgeFormation < _xmin)
        {
            movingRight = true;
        }
        else if (rightEdgeFormation > _xmax)
        {
            movingRight = false;
        }


        if (AllMembersDead())
        {
            SpawnUntilFull();
        }
    }
}
