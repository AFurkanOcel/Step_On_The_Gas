using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class carcode : MonoBehaviour
{
    public float score;
    public int coin;
    public Rigidbody nearcoin;
    public Rigidbody nearcoin2;
    public BoxCollider road1;
    public BoxCollider road2;
    public BoxCollider road3;
    public BoxCollider road4;
    public AudioSource crash;
    public AudioSource collect;
    public AudioSource beep;
    bool gamefinished = false;
    bool gamepaused = false;
    bool dkeypressed = false;
    bool akeypressed = false;
    bool cameraisinfront = false;
    bool lighton = false;
    public BoxCollider cameraa;

    private void Start()
    {
        score = 0;
        coin = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))     // veya " if(Input.GetKey("d")) "
        {
            dkeypressed = true;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     // veya " if(Input.GetKey("a")) "
        {
            akeypressed = true;
        }
        if (Input.GetKey(KeyCode.Escape))     // veya " if(Input.GetKey("escape")) "
        {
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate()
    {
        if (gamefinished == false)
        {
            score += 1f;
            if (GetComponent<Rigidbody>().position.z < 265 && GetComponent<Rigidbody>().position.y <= 0.5)
            {
                GetComponent<Rigidbody>().AddForce(0, 0, 0.00017f);

                //GetComponent<Rigidbody>().AddForce(Vector3.forward * 17, ForceMode.Force);   "boyle kullanirsamda hizlanarak gider"

                /*GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y , 40);
                      "boyle kullanirsam sabit hizla gider (vektor3 un icinde ki x ve y yi boyle belirtmemin sebebi onlari elleme demek)"         */
            }

            else if (GetComponent<Rigidbody>().position.z >= 265 && GetComponent<Rigidbody>().position.z < 500)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 40);
            }

            else if (GetComponent<Rigidbody>().position.z >= 500 && GetComponent<Rigidbody>().position.z < 700)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 30);
            }

            else if (GetComponent<Rigidbody>().position.z >= 700 && GetComponent<Rigidbody>().position.z < 900)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 20);
            }

            else if (GetComponent<Rigidbody>().position.z >= 900 && GetComponent<Rigidbody>().position.z < 1100)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 22);
            }

            else if (GetComponent<Rigidbody>().position.z >= 1100 && GetComponent<Rigidbody>().position.z < 1300)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 24);
            }

            else if (GetComponent<Rigidbody>().position.z >= 1300 && GetComponent<Rigidbody>().position.z < 1500)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 26);
            }

            else if (GetComponent<Rigidbody>().position.z >= 1500 && GetComponent<Rigidbody>().position.z < 1700)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 28);
            }

            else if (GetComponent<Rigidbody>().position.z >= 1700 && GetComponent<Rigidbody>().position.z < 1900)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 30);
            }

            else if (GetComponent<Rigidbody>().position.z >= 1900 && GetComponent<Rigidbody>().position.z < 2100)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 32);
            }

            else if (GetComponent<Rigidbody>().position.z >= 2100 && GetComponent<Rigidbody>().position.z < 2300)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 34);
            }

            else if (GetComponent<Rigidbody>().position.z >= 2300 && GetComponent<Rigidbody>().position.z < 2500)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 36);
            }

            else if (GetComponent<Rigidbody>().position.z >= 2500 && GetComponent<Rigidbody>().position.z < 2700)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 38);
            }

            else if (GetComponent<Rigidbody>().position.z >= 2700)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 40);
            }

            if ((GetComponent<Rigidbody>().position.x >= 10) || (GetComponent<Rigidbody>().position.x <= -10))
            {
                gamefinished = true;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }

            if (dkeypressed)
            {
                GetComponent<Rigidbody>().AddForce(0.00030f, 0, 0);
                dkeypressed = false;
            }

            if (akeypressed)
            {
                GetComponent<Rigidbody>().AddForce(-0.00030f, 0, 0);
                akeypressed = false;
            }
        }

        else if (gamefinished == true)  // (gamefinished) da yazýlabilir
        {
            score += 0f;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Invoke("GameScene", 3f);
        }
    }

    private void LateUpdate()   // burda late update i kullanmam update e karþý hiç avantaj saðlamadý, lateupdate update in içindeki fonksiyonlardan sonra çaðrýldýðý için belki 0.001 saniye artý saðladý yavaþlýk konusunda. sadece o da kodumda olsun diye kullandým.
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cameraisinfront == false)
            {
                cameraa.transform.position += new Vector3(0, -0.5f, 5);
                cameraisinfront = true;
            }
            else if (cameraisinfront == true)
            {
                cameraa.transform.position += new Vector3(0, 0.5f, -5);
                cameraisinfront = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lighton == false)
            {
                GameObject.FindWithTag("light").GetComponent<Light>().enabled = true;
                lighton = true;
            }
            else if (lighton == true)
            {
                GameObject.FindWithTag("light").GetComponent<Light>().enabled = false;
                lighton = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if(gamepaused == false)
            {
                Time.timeScale = 0f;
                gamepaused = true;
            }
            else if(gamepaused == true)
            {
                Time.timeScale = 1f;
                gamepaused = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            beep.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "destroyingcoins")
        {
            Destroy(collision.gameObject);
            coin += 1;
            collect.Play();
        }
        if(collision.collider.tag == "coin")
        {
            Destroy(collision.gameObject);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if(collision.collider.tag == "barrier")
        {
            gamefinished = true;
            crash.Play();
        }
        if (collision.collider.tag == "nearcoin")
        {
            Destroy(collision.gameObject);
            Destroy(nearcoin2);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            Instantiate(nearcoin2).transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if (collision.collider.tag == "nearcoin2")
        {
            Destroy(collision.gameObject);
            Destroy(nearcoin);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            Instantiate(nearcoin).transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if (collision.collider.tag == "specialcoin")
        {
            Destroy(collision.gameObject);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            road1.transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if (collision.collider.tag == "specialcoin2")
        {
            Destroy(collision.gameObject);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            road2.transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if (collision.collider.tag == "specialcoin3")
        {
            Destroy(collision.gameObject);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            road3.transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
        if (collision.collider.tag == "specialcoin4")
        {
            Destroy(collision.gameObject);
            Instantiate(collision.gameObject).transform.position += new Vector3(0, 0, 650);
            road4.transform.position += new Vector3(0, 0, 650);
            coin += 1;
            collect.Play();
        }
    }

    private void GameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void PlaySceneNight()
    {
        SceneManager.LoadScene(2);
    }

    public void Controls()
    {
        SceneManager.LoadScene(3);
    }

    public void Settings()
    {
        SceneManager.LoadScene(4);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Paused()
    {
        if(gamepaused == false)
        {
            Time.timeScale = 0f;
            gamepaused = true;
        }
        else if (gamepaused == true)
        {
            Time.timeScale = 1f;
            gamepaused = false;
        }
    }
}
