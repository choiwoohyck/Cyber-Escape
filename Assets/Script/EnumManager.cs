using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

namespace EnumSpace
{
    public enum MonsterType
    { 
        ROADROBOT,
        ATTACKROBOT,
        RUSHROBOT,
        DUMMY
    }

    public enum ObstacleType
    {
        SPIKETRAP,
        PRESSTRAP
    }

    public enum SoundType
    {
        TIMEOVER,
        PUZZLECORRECT,
        DOOROPEN,
        DOORCLOSE,
        STAGEDOOROPEN,
        WIRECORRECT,
        PRESSSOUND,
        BOSSREADY,
        SPIKETRAP
    }
}
