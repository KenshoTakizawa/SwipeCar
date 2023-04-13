using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetController : MonoBehaviour
{

    GameObject reset;
    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        this.reset = GameObject.Find("Reset");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();


            if (Physics.Raycast(ray, out hit))
            {
                clickedGameObject = hit.collider.gameObject;
                Debug.Log(clickedGameObject);
            }

            if (clickedGameObject == reset)
            {
                SceneManager.LoadScene(0);
            }

        }
    }
}
