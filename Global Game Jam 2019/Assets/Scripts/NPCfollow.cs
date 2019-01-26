using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCfollow : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    public GameObject npc;
    

    // Start is called before the first frame update
    void Start()
    {

        npc = GameObject.Find("player");


    }

    // Update is called once per frame
    void Update()
    {
       
        
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        





    }
}
