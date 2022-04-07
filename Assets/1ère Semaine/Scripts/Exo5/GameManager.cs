using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo5
{
    public class GameManager : MonoBehaviour
    {
        private EnumPhase enumPhase = EnumPhase.DRAW;

        private List<string> listPlayers = new List<string>();
        private int indexPlayer = 0;

        private void Start()
        {
            listPlayers.Add("Player1");
            listPlayers.Add("Player2");
            listPlayers.Add("Player3");
            listPlayers.Add("Player4");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PhaseSwitch();
            }
        }

        private void PhaseSwitch()
        {
            switch (enumPhase)
            {
                case EnumPhase.DRAW:
                    Debug.Log("Vous piochez une carte : " + listPlayers[indexPlayer]);
                    enumPhase += 1;
                    break;
                case EnumPhase.PLAY:
                    Debug.Log("Vous jouez une carte" + listPlayers[indexPlayer]);
                    enumPhase += 1;
                    break;
                case EnumPhase.BATTLE:
                    Debug.Log("Combat" + listPlayers[indexPlayer]);
                    enumPhase += 1;
                    break;
                case EnumPhase.END:
                    Debug.Log("Fin de tour" + listPlayers[indexPlayer]);
                    enumPhase += 1;
                    break;
                default:
                    indexPlayer += 1;
                    if (indexPlayer >= listPlayers.Count)
                    {
                        indexPlayer = 0;
                    }
                    enumPhase = EnumPhase.DRAW;
                    PhaseSwitch();
                    break;
            }
        }
    }
}
