using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_controller : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;

    private void Awake()
    {
        Hero foundHero = FindObjectOfType<Hero>();
        if (foundHero != null)
        {
            player = foundHero.transform;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            pos = player.position;
            pos.z = -10f;
            transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
        }
    }
}
