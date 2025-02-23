﻿namespace MaiLib;

/// <summary>
///     Construct Rest Note solely for Simai
/// </summary>
internal class Rest : Note
{
    #region Constructors
    /// <summary>
    ///     Construct empty
    /// </summary>
    public Rest()
    {
        NoteType = "RST";
        Bar = 0;
        Tick = 0;
        Update();
    }

    /// <summary>
    ///     Construct Rest Note with given information
    /// </summary>
    /// <param name="noteType">Note Type to take in</param>
    /// <param name="bar">Bar to take in</param>
    /// <param name="startTime">Start to take in</param>
    public Rest(string noteType, int bar, int startTime)
    {
        NoteType = noteType;
        Bar = bar;
        Tick = startTime;
        Update();
    }

    /// <summary>
    ///     Construct with Note provided
    /// </summary>
    /// <param name="n">Note to take in</param>
    public Rest(Note n)
    {
        NoteType = "RST";
        Bar = n.Bar;
        Tick = n.Tick;
        BPMChangeNotes = n.BPMChangeNotes;
        Update();
    }
    #endregion

    public override string NoteGenre => "REST";

    public override bool IsNote => false;

    public override string NoteSpecificGenre => "REST";

    public override bool CheckValidity()
    {
        throw new NotImplementedException();
    }

    public override string Compose(int format)
    {
        // return "r_" + this.Tick;
        return "";
    }

    public override Note NewInstance()
    {
        Note result = new Rest(this);
        return result;
    }
}