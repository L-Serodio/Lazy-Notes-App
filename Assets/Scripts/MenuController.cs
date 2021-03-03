using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class MenuController : MonoBehaviour
{
    
   [SerializeField] private GameObject btnWrite;
   [SerializeField] private InputField noteText;
   [SerializeField] private GameObject panelForWrite;
    private String textN = "";
    
    public void createNote() {
        textN = noteText.text;
        Note note = new Note(textN);
        saveNote(note);
    }

    private void saveNoteAsJSON(Note note) {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
