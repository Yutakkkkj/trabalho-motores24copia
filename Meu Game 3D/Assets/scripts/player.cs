using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;
    public int forcaPulo = 10;
    public bool noChao;
    
    void Start()
    {
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ch�o")
        {

        noChao = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");
      Vector3 direcao = new Vector3(h, 0, v);
      rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
      
      if(Input.GetKeyDown(KeyCode.Space) && noChao)
      {
          rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
          noChao = false;
      }
      
      
      if (transform.position.y < -5) 
      {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }

    }
}
