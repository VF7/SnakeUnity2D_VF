using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailGenerator : MonoBehaviour
{
    [SerializeField] private Segment _segmentTamplate;
    [SerializeField] private int _tailSize;

    public List<Segment> Generate()
    {
        var tail = new List<Segment>();

        for (int i = 0; i < _tailSize; i++)
        {
            tail.Add(Instantiate(_segmentTamplate, transform));
        }

        return tail;
    } 
}