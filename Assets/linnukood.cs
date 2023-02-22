using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class linnukood : MonoBehaviour
{
    public Rigidbody2D kovakeha;
    public float linnutugevus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            kovakeha.velocity += Vector2.up * linnutugevus;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kokkupuude"); //logidesse print
        SceneManager.LoadScene("SampleScene"); //laeme stseeni uuesti, algfaasist, et m‰ng uuesti algaks
        score = 0;
    }

    public int score = 0;
    public GameObject Tekstikandja;
    void OnTriggerEnter2D(Collider2D collider)
    {
        score++; //vırdv‰‰rne score += 1-ga
                 //and - &&
                 //or - ||
        Text skoorikandja = Tekstikandja.GetComponent<Text>();
        skoorikandja.text = score.ToString();
    }
}
