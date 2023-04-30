using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public string[,]Board = new string [,] {{"?", "?", "?"}, {"?", "?", "?"}, {"?", "?", "?"}};
    public GameObject[,] buttons = new GameObject [3,3];

    // ROW 1
    public GameObject b00 = new GameObject();
    public GameObject b01 = new GameObject();
    public GameObject b02 = new GameObject();

    // ROW 2
    public GameObject b10 = new GameObject();
    public GameObject b11 = new GameObject();
    public GameObject b12 = new GameObject();

    // ROw 3
    public GameObject b20 = new GameObject();
    public GameObject b21 = new GameObject();
    public GameObject b22 = new GameObject();

    public GameObject xPiece = new GameObject();
    public GameObject oPiece = new GameObject();
    

    int round = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.name == b00.name && Board[0,0] == "?"){
                    Debug.Log("HIT");
                    if (round % 2 == 0){
                        Board[0,0] = "x";
                        round ++;
                        Instantiate(xPiece, new Vector3(b00.transform.position.x,b00.transform.position.y,b00.transform.position.z), Quaternion.identity);
                    }else{
                        Board[0,0] = "o";
                        round ++;
                        Instantiate(oPiece, new Vector3(b00.transform.position.x,b00.transform.position.y,b00.transform.position.z), Quaternion.identity);

                    }
                }
            }
        }
    }
    
    private void OnMouseDown() {
        
    }
}
