using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MenuInterface{
    string GetState();
    void Activate();
    void Deactivate();
    bool Pauseable(); 

}
