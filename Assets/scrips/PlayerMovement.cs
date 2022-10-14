using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveH, moveV;
    [SerializeField] private float moveSpeed = 2.0f;
    public Joystick joystick;
    AudioSource audioSource;



    PlayerSavePos playerPosData;

    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        playerPosData = FindObjectOfType<PlayerSavePos>();
        playerPosData.PlayerPosLoad();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    private void FixedUpdate()
    {

        moveH = joystick.Horizontal * moveSpeed;
        moveV = joystick.Vertical * moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);
        Vector2 direction = new Vector2(moveH, moveV);

        FindObjectOfType<PlayerAnimation>().SetDirection(direction); 
       
    }




}
