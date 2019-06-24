using Chess.Core.Enums;
using Chess.Core.Factories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject BishopWhiteTemplate;
    public GameObject BishopBlackTemplate;
    public GameObject KingWhiteTemplate;
    public GameObject KingBlackTemplate;
    public GameObject KnightWhiteTemplate;
    public GameObject KnightBlackTemplate;
    public GameObject PawnWhiteTemplate;
    public GameObject PawnBlackTemplate;
    public GameObject QueenWhiteTemplate;
    public GameObject QueenBlackTemplate;
    public GameObject RookWhiteTemplate;
    public GameObject RookBlackTemplate;

    // Start is called before the first frame update
    void Start()
    {
        var game = GameFactory.NewGame();
        var board = game.GetBoard();
        foreach(var piece in board)
        {
            var piecesymbol = piece.GetSymbol();
            var piececolor = piece.GetColor();
            GameObject monoPiece = null;
            switch(piecesymbol)
            {
                case PieceSymbol.Bishop:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(BishopWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(BishopBlackTemplate);
                    break;
                case PieceSymbol.King:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(KingWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(KingBlackTemplate);
                    break;
                case PieceSymbol.Knight:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(KnightWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(KnightBlackTemplate);
                    break;
                case PieceSymbol.Pawn:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(PawnWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(PawnBlackTemplate);
                    break;
                case PieceSymbol.Queen:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(QueenWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(QueenBlackTemplate);
                    break;
                case PieceSymbol.Rook:
                    if (piececolor == PieceColor.White)
                        monoPiece = GameObject.Instantiate(RookWhiteTemplate);
                    else
                        monoPiece = GameObject.Instantiate(RookBlackTemplate);
                    break;
            }
            monoPiece.transform.position = new Vector3(-8.9f + ((piece.GetFileNr()-1)*((8.84f + 8.88f)/8)), 1.2f, -8.9f + ((piece.GetRank()-1) * ((8.84f + 8.88f)/8)));
            monoPiece.SetActive(true);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
