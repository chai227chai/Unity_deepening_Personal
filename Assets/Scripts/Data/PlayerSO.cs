using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Characters/Player")]
public class PlayerSO : ScriptableObject
{
    [field: SerializeField] public PlayerGroundData PlayerGroundData { get; private set; }
    [field: SerializeField] public PlayerAirData PlayerAirData { get; private set; }
}
