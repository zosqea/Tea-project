using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_mum : MonoBehaviour
{
    public string goodTag;
    public string badTag;
    public string badgoodTag;
    public string legendaryTag;
    public orders very_sus;
    public string ddd;
    public int score = 0;
    public Text scoreText;
    // & (very_sus == "yellow")
    void Start()
    {
        
    }
    void Update()
    {
        var FBI_CONTROL = orders.marijuana;
        Debug.Log(FBI_CONTROL);
    }

    public void OnTriggerEnter(Collider other) 
    {
        var FBI_CONTROL = orders.marijuana;
        Debug.Log(FBI_CONTROL);
        if (other.gameObject.tag == legendaryTag)
        {
            score += 3;
            Destroy(other.gameObject);
        }
        if ((other.gameObject.tag == goodTag) &&(FBI_CONTROL == "green"))
        {
            score += 1;
            Destroy(other.gameObject);
        }
        if ((other.gameObject.tag == badgoodTag) &&(FBI_CONTROL == "yellow"))
        {
            score += 1;
            Destroy(other.gameObject);
        }
        if ((other.gameObject.tag == badTag) &&(FBI_CONTROL == "red"))
        {
            score += 1;
            Debug.Log("ABHJSDBDSHFAFHKDVBFHKSBJKDFJKAD");
            Destroy(other.gameObject);
        }
        if ((other.gameObject.tag == badTag) |(other.gameObject.tag == badgoodTag) &(FBI_CONTROL == "green"))
        {
            score -= 1;
            Destroy(other.gameObject);
        }
        if (((other.gameObject.tag == badTag) | (other.gameObject.tag == goodTag)) & (FBI_CONTROL == "yellow"))
        {
            score -= 1;
            Destroy(other.gameObject);
        }
        if (((other.gameObject.tag == badgoodTag) | (other.gameObject.tag == goodTag)) & (FBI_CONTROL == "red"))
        {
            score -= 1;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame //wat?
    void FixedUpdate()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -3.49f)
            {
                transform.position += new Vector3(-7*Time.deltaTime,0,0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 3.49f)
            {
                transform.position += new Vector3(7*Time.deltaTime,0,0);
            }
        }
    }
}