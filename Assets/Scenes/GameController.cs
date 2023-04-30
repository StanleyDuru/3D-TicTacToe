using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public GameObject playAgain;
    public TMP_Text winnerText;

    bool end;
    

    int round = 0;
    void Start()
    {
        playAgain.SetActive(false);
        winnerText.enabled = false;
        end = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0) && !end){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.name == b00.name && Board[0,0] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[0,0] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b00.transform.position.x,b00.transform.position.y-1f,b00.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[0,0] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b00.transform.position.x,b00.transform.position.y-1f,b00.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b01.name && Board[0,1] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[0,1] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b01.transform.position.x,b01.transform.position.y-1f,b01.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[0,1] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b01.transform.position.x,b01.transform.position.y-1f,b01.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b02.name && Board[0,2] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[0,2] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b02.transform.position.x,b02.transform.position.y-1f,b02.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[0,2] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b02.transform.position.x,b02.transform.position.y-1f,b02.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b10.name && Board[1,0] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[1,0] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b10.transform.position.x,b10.transform.position.y-1f,b10.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[1,0] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b10.transform.position.x,b10.transform.position.y-1f,b10.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b11.name && Board[1,1] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[1,1] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b11.transform.position.x,b11.transform.position.y-1f,b11.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[1,1] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b11.transform.position.x,b11.transform.position.y-1f,b11.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b12.name && Board[1,2] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[1,2] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b12.transform.position.x,b12.transform.position.y-1f,b12.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[1,2] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b12.transform.position.x,b12.transform.position.y-1f,b12.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b20.name && Board[2,0] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[2,0] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b20.transform.position.x,b20.transform.position.y-1f,b20.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[2,0] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b20.transform.position.x,b20.transform.position.y-1f,b20.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b21.name && Board[2,1] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[2,1] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b21.transform.position.x,b21.transform.position.y-1f,b21.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[2,1] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b21.transform.position.x,b21.transform.position.y-1f,b21.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }else if(hit.transform.name == b22.name && Board[2,2] == "?"){
                    Debug.Log("HIT");
                    Debug.Log(round);
                    string s = "";
                    if (round % 2 == 0){
                        s = "x";
                        Board[2,2] = s;
                        round ++;
                        Instantiate(xPiece, new Vector3(b22.transform.position.x,b22.transform.position.y-1f,b22.transform.position.z), Quaternion.identity);
                    }else{
                        s = "o";
                        Board[2,2] = s;
                        round ++;
                        Instantiate(oPiece, new Vector3(b22.transform.position.x,b22.transform.position.y-1f,b22.transform.position.z), Quaternion.identity);

                    }
                    CheckWin(Board, s);
                }
            }
        }
    }
    
    private void OnMouseDown() {
        
    }

    public void CheckWin(string[,] board, string player){
        // Check rows
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] == player && board[row, 1] == player && board[row, 2] == player)
            {
                Debug.Log(player+" wins");
                playAgain.SetActive(true);
                winnerText.enabled = true;
                winnerText.text = player.ToUpper() + " Wins!";
                end = true;
                break;
                // return true;
            }
        }

        // Check columns
        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] == player && board[1, col] == player && board[2, col] == player)
            {
                Debug.Log(player+" wins");
                playAgain.SetActive(true);
                winnerText.enabled = true;
                winnerText.text = player.ToUpper() + " Wins!";
                end = true;
                break;
                // return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        {
            Debug.Log(player+" wins");
            playAgain.SetActive(true);
            winnerText.enabled = true;
            winnerText.text = player.ToUpper() + " Wins!";
            end = true;

            //return true;
        }

        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        {
            Debug.Log(player+" wins");
            playAgain.SetActive(true);
            winnerText.enabled = true;
            winnerText.text = player.ToUpper() + " Wins!";
            end = true;

            //return true;
        }

        // No win found
        if(round == 9){
            playAgain.SetActive(true);
            winnerText.enabled = true;
            winnerText.text = "No Winner :(";
            end = true;
        }
        Debug.Log("no win");

        //return false;
    }
    public void restart(){
        Debug.Log("clicked");
        Board = new string [,] {{"?", "?", "?"}, {"?", "?", "?"}, {"?", "?", "?"}};
        round = 0;
        winnerText.enabled = false;
        playAgain.SetActive(false);
        end = false;
        GameObject[] del = GameObject.FindGameObjectsWithTag("X");
        foreach(GameObject obj in del){
            Destroy(obj);
        }
        del = GameObject.FindGameObjectsWithTag("O");
        foreach(GameObject obj in del){
            Destroy(obj);
        }

        
    }

}
