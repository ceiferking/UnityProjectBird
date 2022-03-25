using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    public float Fpulo;
    public Transform gamestart;
    public Transform gameover;
    Rigidbody2D rb;
    public Text ScoreView;
    [SerializeField]
    int score;
    // Start is called before the first frame update
    void Start()
    {
        gamestart.gameObject.SetActive(true);
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            rb.velocity = Vector2.up * Fpulo;
        }
    }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            if(collision.CompareTag("addscore"))
            {
                score++;
                ScoreView.text = score.ToString();
            }
            if(collision.CompareTag("pipe"))
            {
                enabled = false;
                gameover.gameObject.SetActive(true);
                Invoke("Pause", 2);
            }
        }

        void Pause()
        {
            Time.timeScale = 0;
        }

        public void Startgamer()
        {
            Time.timeScale = 1;
            gamestart.gameObject.SetActive(false);
        }

}
