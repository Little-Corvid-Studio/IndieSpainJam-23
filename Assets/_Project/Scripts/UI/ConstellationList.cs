using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ConstellationNames
{
    ARIES,
    TAURUS,
    GEMINI,
    VIRGO,
    LIBRA,
    CANCER,
    SCORPIO,
    SAGITARIO,
    CAPRICORNIO,
    AQUARIUS,
    PISCIS,

    NUM_CONSTELLATIONS
}

public struct ConstellationData
{
    public int numEstrellas;
    public int[] conexiones;
}
public class ConstellationList
{
    public ConstellationData getConstellationData(ConstellationNames names)
    {
        ConstellationData data = new ConstellationData();
        switch (names)
        {
            case ConstellationNames.ARIES:
                data.numEstrellas = 3;
                data.conexiones= new int[2];
                data.conexiones[0] = 1;
                data.conexiones[1] = 2;
                
                break;
            case ConstellationNames.TAURUS:
                break;
            case ConstellationNames.GEMINI:
                break;
            case ConstellationNames.VIRGO:
                break;
            case ConstellationNames.CANCER:
                break;
            case ConstellationNames.LIBRA: break;

            case ConstellationNames.SCORPIO:
                break;
             
        }

        return data;
    }

}
