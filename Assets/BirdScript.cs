using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Birdrigidbody;
    public float flapStrength;
    public LogicManagerScript logic;
    public AudioManagerScript audio;
    public bool birdStatus;
    private Camera mainCamera;
    public Animator animator;
    public float gameOverYThreshold = -10f;
    void Start()
    {
        mainCamera = Camera.main;
        gameObject.name = "Stupid Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerScript>();
        birdStatus = true;
        //animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float cameraLowestY = mainCamera.transform.position.y - (mainCamera.orthographicSize);
        if (Input.GetMouseButtonDown(0) && birdStatus == true)
        {
               animator.enabled = true;

            audio.playSFX(audio.wing);
            Birdrigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < cameraLowestY)
        {
            if (birdStatus == true)
            {
                audio.playSFX(audio.die);
                audio.playSFX(audio.hit);
                logic.gameOver();
            }
            birdStatus = false;
        }
    }
    public void EnableAnimator()
    {
        animator.enabled = true;
    }
    public void DisableAnimator()
    {
        animator.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {   if (birdStatus == true)
        {
            audio.playSFX(audio.die);
            audio.playSFX(audio.hit);
            logic.gameOver();
        }

        birdStatus = false;
    }

}
