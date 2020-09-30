using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueEventArgs : EventArgs
{
    public Dialogue dialoguePayload; 
}

public static class GameEvents
{
    public static event EventHandler<DialogueEventArgs> DialogInitiated;
    public static event EventHandler DialogFinished;

    public static void InvokeDialogInitiated(Dialogue dialog) 
    {
        DialogInitiated(null, new DialogueEventArgs { dialoguePayload = dialog });
    }

    public static void InvokeDialogFinished()
    {
        DialogFinished(null, EventArgs.Empty);
    }
}
