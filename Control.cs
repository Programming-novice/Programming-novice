using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Control : MonoBehaviour
{
    // Start is called before the first frame update

    

    int speed = 20; //스피드 
    bool facingRight = false;

    void Start()
    {
        
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x축으로 이동할 양
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y축으로 이동할양
        this.transform.Translate(new Vector2(xMove, yMove));  //이동


        


        if (Input.GetKey(KeyCode.LeftArrow) && facingRight)   //왼쪽 방향전환
        {
            

            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            facingRight = false;

        } else if (Input.GetKey(KeyCode.RightArrow) && !facingRight) //오른쪽 방향전환
        {
            

            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            facingRight = true;

        }


    }

    


}
