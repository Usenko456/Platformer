using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float speed = 1.5f;
    Vector3 targetpos;
    public GameObject ways;
    public Transform[] waypoints;
    int pointindex;
    int pointcount;
    int direction;
  
    private SpriteRenderer sprite;
    private void Awake()
    {
        waypoints = new Transform[ways.transform.childCount];
        for (int i = 0; i < ways.gameObject.transform.childCount; i++)
        {
            waypoints[i]=ways.transform.GetChild(i).gameObject.transform;
        }
    }
    private void Start()
    {
        pointcount= waypoints.Length;
        pointindex = 0;
        targetpos = waypoints[pointindex].transform.position;
    }
    private void Update()
    {
        var step = speed* Time.deltaTime;
        transform.position=Vector3.MoveTowards(transform.position, targetpos, step);
        if (transform.position == targetpos)
        {
            Nextpoint();
        }
    }
    void Nextpoint()
    {
        if (pointindex == pointcount - 1)
        {
            direction = -1;
        }
        if (pointindex == 0)
        {
            direction=1;
        }
        pointindex += direction;
        targetpos = waypoints[pointindex].transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
        
            collision.collider.transform.SetParent(null);
        }
    }
}
