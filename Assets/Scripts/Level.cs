using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public List<List<Field>> levelLayout;

    public int width;
    public int height;

    public List<Vector2Int> targets; // lista współrzęnych, na których są pola docelowe

    public Level() {
        string demoLevel =
@"######
#...##
#@.$_#
#...##
######";
        CreateFromString(demoLevel);
    }

    public Level(string s) {
        CreateFromString(s);
    }

    private void CreateFromString(string s) {
        //TODO uzupelnic tworzenie poziomu
        // # - sciana
        // . - podloga
        // @ - gracz
        // $ - skrzynka
        // _ - miejsce docelowe

    }
}
