using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;
    public float Ychanger;

    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<Hero>().transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pos = player.position;
        pos.y += Ychanger;
        pos.z = -10f;

        if (pos.x > 5.3f)
            pos.x = 5.3f;
        else if (pos.x < -5.6f)
            pos.x = -5.6f;
        
        transform.position = Vector3.Lerp(transform.position, pos, 10*Time.deltaTime);

    }
}
