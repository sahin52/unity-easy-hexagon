using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float speed = 600f;
    float movement = 0f;
    public int playing=1;
    public Text Text;
    public int score;
    // Update is called once per frame
    void Start(){
        score = (int) Time.time;
    }

    void Update()
    {   if(playing==1){
        movement = Input.GetAxisRaw("Horizontal");
        }

    }
    private void FixedUpdate(){
        if(playing==1){
        transform.RotateAround(Vector3.zero,Vector3.forward,movement*Time.fixedDeltaTime*-speed);
        }
        else{
            if(Input.GetMouseButtonDown(0)){
                playing = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(playing==1){
            playing = 0;
            score = (int)Time.time - score;
            Text.gameObject.SetActive(true);
            score = score-1;
            Text.text="Your got " + score +" points" + "\nClick to replay" ;
        }
    }

}
